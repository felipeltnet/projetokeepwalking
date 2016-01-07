using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
    public class Modelo
    {

        public void inserir(String idMarca, String descricao)
        {
            pModelo objModelo = new pModelo();
            objModelo.inserir(idMarca, descricao); 
        }

        public void alterar(String idModelo, String nomeModelo)
        {
            pModelo objModelo = new pModelo();
            objModelo.alterar(idModelo, nomeModelo);
        }

        public void deletar(String idModelo)
        {
            pModelo objModelo = new pModelo();
            objModelo.deletar(idModelo);
        }

        public DataSet consultarTodos()
        {
            pModelo objModelo = new pModelo();
            return objModelo.consultarTodos();
        }

       


    }
}
