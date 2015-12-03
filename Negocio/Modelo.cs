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
        String descricao;

        public void inserir(String descricao)
        {
            pModelo objModelo = new pModelo();
            objModelo.inserir(descricao); 
        }

        public void alterar()
        {

        }

        public void apagar()
        {

        }

        public DataSet consultarTodos()
        {
            pModelo objModelo = new pModelo();
            return objModelo.consultarTodos();
        }

       


    }
}
