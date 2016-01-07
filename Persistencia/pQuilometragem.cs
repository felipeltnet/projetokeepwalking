using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
   public class pQuilometragem
    {
        String quilometragem;

        public void adicionar(String quilometragem)
        {
            String SQL = "INSERT INTO Quilometragem(quilometragem) VALUES('" + quilometragem + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();

        }
        public void deletar(String idQuilometragem)
        {
            String SQL = "DELETE Quilometragem WHERE idQuilometragem =" + idQuilometragem;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void alterar(String idQuilometragem, String quilometragem)
        {
            String SQL = "UPDATE Quilometragem SET quilometragem = '" + quilometragem + "' WHERE idQuilometragem = " + idQuilometragem;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public DataSet consultar()
        {
            String SQL = "SELECT * FROM Quilometragem";

            Conexao objConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, objConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            objConexao.fechaConexao();

            return ds;
        }
    }
}