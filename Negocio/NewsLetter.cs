using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
    public class NewsLetter
    {

        public void adicionar(String email)
        {
            pNewsLetter objNewsLetter = new pNewsLetter();
            objNewsLetter.adicionar(email);
        }
        public void deletar(String idEmail)
        {
            pNewsLetter objNewsLetter = new pNewsLetter();
            objNewsLetter.deletar(idEmail);
        }
        public void alterar(String idEmail, String email)
        {
            pNewsLetter objNewsLetter = new pNewsLetter();
            objNewsLetter.alterar(idEmail, email);
        }
        public DataSet consultar()
        {
            pNewsLetter objNewsLetter = new pNewsLetter();
            return objNewsLetter.consultar();
        }
    }
}
