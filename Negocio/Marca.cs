using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class Marca
    {
        String nomeMarca;

        public void adicionar(String nomeMarca)
        {
            pMarca objMarca = new pMarca();
            objMarca.adicionar(nomeMarca);
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
