using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia

{
    public class pModelo
    {
        String descricao;

        public void inserir(String descricao)
        {
            String SQL = "INSERT INTO Modelo(idMarca, descricao) VALUES (1, '" + descricao+"')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void alterar(String idModelo, String nomeModelo)
        {
            String SQL = "UPDATE Modelo" + " SET nomeModelo = '" + nomeModelo + "' WHERE idModelo = '" + idModelo + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void deletar(String idModelo)
        {
            String SQL = "DELETE Modelo WHERE idModelo = " + idModelo;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public DataSet consultarTodos()
        {
            String SQL = "SELECT * FROM Modelo";
            Conexao oConexao = new Conexao("SQLServer");
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");
            oConexao.fechaConexao();
            return ds;
        }
    }
}
