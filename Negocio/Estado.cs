using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class Estado
    {
        String estado;
        

        public void adicionar(String estado)
        {
            pEstado objEstado = new pEstado();
            objEstado.adicionar(estado);
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
