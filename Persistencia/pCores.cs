using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    public class pCores
    {
        String nomeCores;

        public void adicionar(String nomeCores)
        {
            String SQL = "INSERT INTO Cores(nomeCor) VALUES ('" +  nomeCores + "')";
            Conexao objConexao = new Conexao("SQLServer");
            objConexao.executeNoQuery(SQL);
            objConexao.fechaConexao();
        }
        public void deletar(String idCores)
        {
            String SQL = "DELETE Cores WHERE idCores = '" + idCores + "' ";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void alterar(String idCores, String nomeCores)
        {
            String SQL = "UPDATE Cores SET nomeCores = '" + nomeCores + "' WHERE idCores = '" + idCores + "'";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public DataSet consultar()
        {
            String SQL = "SELECT * FROM Cores";
            Conexao oConexao = new Conexao("SQLServer");
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");
            oConexao.fechaConexao();
            return ds;
            
        }
    }
}
