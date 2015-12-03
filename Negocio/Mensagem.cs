using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

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
        public void deletar(String idMensagem)
        {
            pMensagem objMensagem = new pMensagem();
            objMensagem.deletar(idMensagem);
        }
        public void alterar(String mensagem, String assunto, String idMensagem)
        {
            pMensagem objMensagem = new pMensagem();
            objMensagem.alterar(idMensagem,assunto, mensagem);
        }
        public DataSet consultar()
        {
            pMensagem objMensagem = new pMensagem();
            return objMensagem.consultar(); ; 
        }
    }
    
}
