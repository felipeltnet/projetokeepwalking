using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
   public class pPublicidade
    {
        String dataInicial;
        String dataFinal;
        String Valor;

        public void adicionar(String dataInicial, String dataFinal, String Valor)
        {
            String SQL = "INSERT INTO Publicidade(dataInicial, dataFinal, Valor) VALUES('" + dataInicial + "', '" + dataFinal + "', '" + Valor + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();

        }
        public void deletar(String idPublicidade)
        {
            String SQL = "DELETE Publicidade WHERE idPublicidade = '" + idPublicidade + "'";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void alterar(String dataInicial, String dataFinal, String Valor)
        {
            String SQL = "UPDATE Publicidade  SET dataInicial = '" + dataInicial + "' WHERE dataFinal = '" + dataFinal + "'WHERE Valor = '" + Valor + "'";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public DataSet consultar()
        {
            String SQL = "SELECT * FROM Publicidade";

            Conexao objConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, objConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            objConexao.fechaConexao();

            return ds;
        }
    }
    }

