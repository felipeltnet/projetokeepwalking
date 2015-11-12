using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class NewsLetter
    {
        String email;

        public void adicionar(String email)
        {
            pNewsLetter objNewsLetter = new pNewsLetter();
            objNewsLetter.adicionar(email);
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
