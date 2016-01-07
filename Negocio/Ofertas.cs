using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Persistencia;

namespace Negocio
{
    public class Ofertas
    {
        String nomeOfertas;

        public void adicionar(String nomeOfertas)
        {
            pOfertas objOfertas = new pOfertas();
            objOfertas.adicionar(nomeOfertas);
        }
        public void deletar(String idOfertas)
        {
            pOfertas objOfertas = new pOfertas();
            objOfertas.deletar(idOfertas);
        }
        public void alterar(String idOfertas, String nomeOfertas)
        {
            pOfertas objOfertas = new pOfertas();
            objOfertas.alterar(idOfertas, nomeOfertas);
        }
        public DataSet consultar()
        {
            pOfertas objOfertas = new pOfertas();
            return objOfertas.consultar();
        }
    }
}
