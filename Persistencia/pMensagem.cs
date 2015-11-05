using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Persistencia
{
    public class pMensagem
    {
        String assunto;
        String mensagem;

        public void adicionar(String mensagem, String assunto)
        {
            String SQL = "INSERT INTO Mensagem(idUsuario, assunto, mensagem) VALUES(2, '"+ assunto +"','"+ mensagem +"')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void alterar()
        {

        }
        public void deletar()
        {

        }
        public String consultar()
        {
            return "";
        }
    }
}
