using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class Mensagem
    {
        String assunto;
        String mensagem;

        public void adicionar(String assunto, String mensagem) 
        {
            pMensagem objMensagem = new pMensagem();
            objMensagem.adicionar(mensagem, assunto);
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
