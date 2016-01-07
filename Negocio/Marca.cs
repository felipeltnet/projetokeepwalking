using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
    public class Marca
    {
        String nomeMarca;

        public void adicionar(String idCategoria, String nomeMarca)
        {
            pMarca objMarca = new pMarca();
            objMarca.adicionar(idCategoria, nomeMarca);
        }
        public void alterar(String nomeMarca, String idMarca)
        {
            pMarca objMarca = new pMarca();
            objMarca.alterar(nomeMarca, idMarca);
        }
        public void deletar(String idMarca)
        {
            pMarca objMarca = new pMarca();
            objMarca.deletar(idMarca);
        }
        public DataSet consultar()
        {
            pMarca objMarca = new pMarca();
            return objMarca.consultar();
        }
    }
}
