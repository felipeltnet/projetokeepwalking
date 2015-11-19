using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class Cores
    {
        String nomeCor;

        public void adicionar(String nomeCor)
        {
            pCores objCores = new pCores();
            objCores.adicionar(nomeCor);
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
