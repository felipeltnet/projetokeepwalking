using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void deletar()
        {
        }
        public void alterar()
        {
        }
        public String consultar()
        {
            return "";
        }
    }
}
