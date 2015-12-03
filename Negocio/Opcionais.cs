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
        public void adicionar(String nomeOpcionais)
        {
            pOpcionais objOpcionais = new pOpcionais();
            objOpcionais.adicionar(nomeOpcionais);
        }
        public void deletar(String idOpcionais)
        {
            pOpcionais objOpcionais = new pOpcionais();
            objOpcionais.deletar(idOpcionais);
        }
        public void alterar(String idOpcionais, String nomeOpcionais)
        {
            pOpcionais objOpcionais = new pOpcionais();
            objOpcionais.alterar(idOpcionais, nomeOpcionais);
        }
        public DataSet consultar()
        {
            pOpcionais objOpcionais = new pOpcionais();
            return objOpcionais.consultar();
        }
    }
}

