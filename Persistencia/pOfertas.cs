using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    public class pOfertas
    {
        String nomeOfertas;

        public void adicionar(String nomeOfertas)
        {
            String SQL = "INSERT INTO Ofertas(nomeOfertas) VALUES('" + nomeOfertas + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();

        }
        public void deletar(String idOfertas)
        {
            String SQL = "DELETE Ofertas WHERE idOfertas =" + idOfertas;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void alterar(String idOfertas, String nomeOfertas)
        {
            String SQL = "UPDATE Ofertas SET nomeOfertas = '" + nomeOfertas + "' WHERE idOfertas = " + idOfertas;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public DataSet consultar()
        {
            String SQL = "SELECT * FROM Ofertas";

            Conexao objConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, objConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            objConexao.fechaConexao();

            return ds;
        }
    }
}
