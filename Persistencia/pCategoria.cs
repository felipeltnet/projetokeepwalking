using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    public class pCategoria
    {
        String nomeCategoria;

        public void adicionar(String nomeCategoria)
        {
            String SQL = "INSERT INTO Categoria(nomeCategoria) VALUES('" + nomeCategoria + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();

        }
        public void deletar(String idCategoria)
        {
            String SQL = "DELETE Categoria WHERE idCategoria =" + idCategoria;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void alterar(String idCategoria, String nomeCategoria)
        {
            String SQL = "UPDATE Categoria SET nomeCategoria = '" + nomeCategoria + "' WHERE idCategoria = " + idCategoria;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public DataSet consultar()
        {
            String SQL = "SELECT * FROM Categoria";

            Conexao objConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, objConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            objConexao.fechaConexao();

            return ds;
        }
    }
}
