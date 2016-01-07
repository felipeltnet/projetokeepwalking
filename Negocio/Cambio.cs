using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Persistencia;

namespace Negocio
{
    public class Cambio
    {
        String nomeCambio;

        public void adicionar(String nomeCambio)
        {
            pCambio objCambio = new pCambio();
            objCambio.adicionar(nomeCambio);
        }
        public void deletar(String idCambio)
        {
            pCambio objCambio = new pCambio();
            objCambio.deletar(idCambio);
        }
        public void alterar(String idCambio, String nomeCambio)
        {
            pCambio objCambio = new pCambio();
            objCambio.alterar(idCambio, nomeCambio);
        }
        public DataSet consultar()
        {
            pCambio objCambio = new pCambio();
            return objCambio.consultar();
        }
    }
}
