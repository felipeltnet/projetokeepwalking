using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
    public class Estado
    {
        public void adicionar(String nomeEstado)
        {
            pEstado objEstado = new pEstado();
            objEstado.adicionar(nomeEstado);
        }
        public void deletar(String idEstado)
        {
            pEstado objEstado = new pEstado();
            objEstado.deletar(idEstado);
        }
        public void alterar(String idEstado, String nomeEstado)
        {
            pEstado objEstado = new pEstado();
            objEstado.alterar(idEstado, nomeEstado);
        }
        public DataSet consultar()
        {
            pEstado objEstado = new pEstado();
            return objEstado.consultar();
        }
    }
}
