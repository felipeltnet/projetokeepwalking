using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    public class pRegiao
    {
        String nomeRegiao;

        public void inserir(String nomeRegiao)
        {
            String SQL = "INSERT INTO Regiao(nomeRegiao) VALUES ('" + nomeRegiao + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();

        }
        public void alterar(String nomeRegiao)
        {

        }
        public void deletar(String nomeRegiao)
        {

        }
        public DataSet consultar()
        {
            String SQL = "SELECT * FROM Regiao";
            Conexao oConexao = new Conexao("SQLServer");
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");
            oConexao.fechaConexao();
            return ds;
        }
    }
}
