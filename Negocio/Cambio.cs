using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
    public class Cambio
    {
        String nomeCambio;

        public void inserir(String cambio)
        {
            pCambio objCambio = new pCambio();
            objCambio.inserir(nomeCambio);
        }

        public void alterar(String idCambio, String nomeCambio)
        {
            pCambio objCambio = new pCambio();
            objCambio.alterar(idCambio, nomeCambio);
        }

        public void deletar(String idCambio)
        {
            pCambio objCambio = new pCambio();
            objCambio.deletar(idCambio);
        }

        public DataSet consultarTodos()
        {
            pCambio objCambio = new pCambio();
            return objCambio.consultarTodos();
        }
    }
}
