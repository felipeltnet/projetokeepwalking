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
        String usuario;

        public void adicionar(String mensagem, String assunto, String usuario)
        {
            String SQL = "INSERT INTO Mensagem(usuario, assunto, mensagem) VALUES('"+ usuario +","+ assunto +","+ mensagem +"')";
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
