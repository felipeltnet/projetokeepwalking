using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public class pMarca
    {
        String nomeMarca;

        public void adicionar(String nomeMarca)
        {
            String SQL = "INSERT INTO Marca(nomeMarca) VALUES('"+nomeMarca+"')";
            Conexao objConexao = new Conexao("SQLServer");
            objConexao.executeNoQuery(SQL);
            objConexao.fechaConexao();
        }
        public void alterar(String nomeMarca, String idMarca)
        {
            String SQL = "UPDATE Marca SET nomeMarca = '" + nomeMarca + "' WHERE idMarca = " + idMarca;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void deletar(String idMarca)
        {
            String SQL = "DELETE Marca WHERE idMarca =" + idMarca;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public DataSet consultar()
        {
            String SQL = "SELECT * FROM Marca";

            Conexao objConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, objConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            objConexao.fechaConexao();

            return ds;
        }
    }
}
