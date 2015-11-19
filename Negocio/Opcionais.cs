using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
   public class Opcionais
    {        
       String nomeOpcionais;

        public void adicionar(String nomeOpcionais)
        {
            pOpcionais objOpcionais = new pOpcionais();
            objOpcionais.adicionar(nomeOpcionais);
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

