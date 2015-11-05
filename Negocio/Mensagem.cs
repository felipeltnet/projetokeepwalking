using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Mensagem
    {
        int idFale;
        int idUsuario;
        String assunto;
        String mensagem;

        public void adicionar(String assunto, String mensagem, String usuario) 
        {
            Mensagem pMensagem = new Mensagem();
            pMensagem.adicionar(usuario, mensagem, assunto);
        }
        public void deletar()
        { }
        public void alterar()
        { }
        public String consultar()
        {
            return ""; 
        }
    }
    
}
