using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Persistencia;

namespace Negocio
{
    public class Combustivel
    {
        String nomeCombustivel;

        public void adicionar(String nomeCombustivel)
        {
            pCombustivel objCombustivel = new pCombustivel();
            objCombustivel.adicionar(nomeCombustivel);
        }
        public void deletar(String idCombustivel)
        {
            pCombustivel objCombustivel = new pCombustivel();
            objCombustivel.deletar(idCombustivel);
        }
        public void alterar(String idCombustivel, String nomeCombustivel)
        {
            pCombustivel objCombustivel = new pCombustivel();
            objCombustivel.alterar(idCombustivel, nomeCombustivel);
        }
        public DataSet consultar()
        {
            pCombustivel objCombustivel = new pCombustivel();
            return objCombustivel.consultar();
        }
    }
}
