using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    public class pCambio
    {
        String cambio;

        public void inserir(String cambio)
        {
            String SQL = "INSERT INTO Cambio(idMarca, cambio) VALUES (1, '" + cambio + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void alterar(String idCambio, String nomeCambio)
        {
            String SQL = "UPDATE Cambio" + " SET nomeCambio = '" + nomeCambio + "' WHERE idCambio = '" + idCambio + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void deletar(String idCambio)
        {
            String SQL = "DELETE Cambio WHERE idCambio = " + idCambio;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public DataSet consultarTodos()
        {
            String SQL = "SELECT * FROM Cambio";
            Conexao oConexao = new Conexao("SQLServer");
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");
            oConexao.fechaConexao();
            return ds;
        }
    }
}
