using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    public class pPatrocinador
    {
        public void adicionar(String nomePatrocinador)
        {
            String SQL = "INSERT INTO Patrocinadores(nomePatrocinador) VALUES('" + nomePatrocinador + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void alterar(String idPatrocinador, String nomePatrocinador)
        {
            String SQL = "UPDATE Patrocinadores" + " SET nomePatrocinador = '" + nomePatrocinador + "' WHERE idPatrocinador = '" + idPatrocinador + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void deletar(String idPatrocinador)
        {
            String SQL = "DELETE Patrocinadores WHERE idPatrocinador = "+ idPatrocinador;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public DataSet consultar()
        {
            String SQL = "SELECT * FROM Patrocinadores";
            Conexao oConexao = new Conexao("SQLServer");
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");
            oConexao.fechaConexao();
            return ds;
        }
    }
}
