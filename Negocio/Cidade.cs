using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Persistencia;

namespace Negocio
{
    public class Cidade
    {
        public void adicionar(String nomeCidade)
        {
            pCidade objCidade = new pCidade();
            objCidade.adicionar(nomeCidade);
        }
        public void deletar(String idCidade)
        {
            pCidade objCidade = new pCidade();
            objCidade.deletar(idCidade);
        }
        public void alterar(String idCidade, String nomeCidade)
        {
            pCidade objCidade = new pCidade();
            objCidade.alterar(idCidade, nomeCidade);
        }
        public DataSet consultar()
        {
            pCidade objCidade = new pCidade();
            return objCidade.consultar();
        }
    }
}
