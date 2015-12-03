using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

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
        public void deletar(String idCores)
        {
            pCores objCores = new pCores();
            objCores.deletar(idCores);
        
        }
        public void alterar(String idCores, String nomeCores)
        {
            pCores objCores = new pCores();
            objCores.alterar(idCores, nomeCores); 
        }
       
        public DataSet consultar()
        {
            pCores objCores = new pCores();
            return objCores.consultar();
        }
    }
}
