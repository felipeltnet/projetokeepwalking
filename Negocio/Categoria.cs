using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Persistencia;

namespace Negocio
{
    public class Categoria
    {
        String nomeCategoria;

        public void adicionar(String nomeCategoria)
        {
            pCategoria objCategoria = new pCategoria();
            objCategoria.adicionar(nomeCategoria);
        }
        public void deletar(String idCategoria)
        {
            pCategoria objCategoria = new pCategoria();
            objCategoria.deletar(idCategoria);
        }
        public void alterar(String idCategoria, String nomeCategoria)
        {
            pCategoria objCategoria = new pCategoria();
            objCategoria.alterar(idCategoria, nomeCategoria);
        }
        public DataSet consultar()
        {
            pCategoria objCategoria = new pCategoria();
            return objCategoria.consultar();
        }
    }
}
