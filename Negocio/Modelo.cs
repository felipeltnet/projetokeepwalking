using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

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

        public Object consultarTodos()
        {
            return 1;
        }

        public String buscar_CPF()
        {
            return "";
        }

        public int calcularIdade()
        {
            return 1;
        }


    }
}
