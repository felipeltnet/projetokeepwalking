using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    public class pMensagem
    {
        

        public void adicionar(String mensagem, String assunto)
        {
            String SQL = "INSERT INTO Mensagem(idUsuario, assunto, mensagem) VALUES(2, '"+ assunto +"','"+ mensagem +"')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void alterar(String mensagem, String assunto, String idMensagem)
        {
            String SQL = "UPDATE Mensagem" + " SET assunto = '" + assunto + "', mensagem = '" + mensagem + "' WHERE idMensagem = '" + idMensagem + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void deletar(String idMensagem)
        {
            String SQL = "DELETE Mensagem WHERE idMensagem = " + idMensagem;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public DataSet consultar()
        {
            String SQL = "SELECT * FROM Mensagem";
            Conexao oConexao = new Conexao("SQLServer");
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");
            oConexao.fechaConexao();
            return ds; ;
        }        
    }
}
