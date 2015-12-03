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
        String nomeCores;
        String idCores;

        public void adicionar(String nomeCores)
        {
            pCores objCores = new pCores();
            objCores.adicionar(nomeCores);
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
