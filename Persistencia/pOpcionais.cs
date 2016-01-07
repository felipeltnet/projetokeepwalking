using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    public class pOpcionais
    {
        public void adicionar(String nomeOpcionais)
        {
            String SQL = "INSERT INTO Opcionais(nomeOpcional) VALUES('" + nomeOpcionais + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void alterar(String idOpcionais, String nomeOpcionais)
        {
            String SQL = "UPDATE Opcionais" + " SET nomeOpcionais = '" + nomeOpcionais + "' WHERE idOpcionais = '" + idOpcionais + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void deletar(String idOpcionais)
        {
            String SQL = "DELETE Opcionais WHERE idOpcionais = " + idOpcionais;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public DataSet consultar()
        {
            String SQL = "SELECT * FROM Opcionais";
            Conexao oConexao = new Conexao("SQLServer");
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");
            oConexao.fechaConexao();
            return ds;
        }
    }
}
