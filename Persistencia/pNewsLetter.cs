using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    public class pNewsLetter
    {
        String email;
        String idEmail;

        public void adicionar(String email)
        {
            String SQL = "INSERT INTO NewsLetter(email) VALUES('" + email +"')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void alterar(String idEmail, String email)
        {
            String SQL = "UPDATE NewsLetter SET email = '" + email + "' WHERE idNewsLetter = '" + idEmail + "'";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void deletar(String idEmail)
        {
            String SQL = "DELETE FROM NewsLetter WHERE idNewsLetter = '" + idEmail + "'";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public DataSet consultar()
        {
            String SQL = "SELECT * FROM NewsLetter";

            Conexao objConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, objConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            objConexao.fechaConexao();
            return ds;
        }
    }
}
