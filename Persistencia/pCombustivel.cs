using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    public class pCombustivel
    {
        String nomeCombustivel;

        public void adicionar(String nomeCombustivel)
        {
            String SQL = "INSERT INTO Combustivel(nomeCombustivel) VALUES('" + nomeCombustivel + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();

        }
        public void deletar(String idCombustivel)
        {
            String SQL = "DELETE Combustivel WHERE idCombustivel =" + idCombustivel;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void alterar(String idCombustivel, String nomeCombustivel)
        {
            String SQL = "UPDATE Combustivel SET nomeCombustivel = '" + nomeCombustivel + "' WHERE idCombustivel = " + idCombustivel;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public DataSet consultar()
        {
            String SQL = "SELECT * FROM Combustivel";

            Conexao objConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, objConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            objConexao.fechaConexao();

            return ds;
        }
    }
}
