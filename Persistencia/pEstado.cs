using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
     public class pEstado
     {
         public void adicionar(String idRegiao,String nomeEstado)
         {
             String SQL = "INSERT INTO Estado(idRegiao, nomeEstado) VALUES( '" + idRegiao + "','" + nomeEstado + "')";
             Conexao oConexao = new Conexao("SQLServer");
             oConexao.executeNoQuery(SQL);
             oConexao.fechaConexao();
         }
         public void alterar(String idEstado, String nomeEstado)
         {
             String SQL = "UPDATE Estado" + " SET nomeEstado = '" + nomeEstado + "' WHERE idEstado = '" + idEstado + "')";
             Conexao oConexao = new Conexao("SQLServer");
             oConexao.executeNoQuery(SQL);
             oConexao.fechaConexao();
         }
         public void deletar(String idEstado)
         {
             String SQL = "DELETE Estado WHERE idEstado = " + idEstado;
             Conexao oConexao = new Conexao("SQLServer");
             oConexao.executeNoQuery(SQL);
             oConexao.fechaConexao();
         }
         public DataSet consultar()
         {
             String SQL = "SELECT * FROM Estado";
             Conexao oConexao = new Conexao("SQLServer");
             SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
             DataSet ds = new DataSet("Tabela");
             adapter.Fill(ds, "Tabela");
             oConexao.fechaConexao();
             return ds;
         }
    }
}
