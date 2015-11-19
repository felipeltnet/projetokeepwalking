using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
    public class Regiao
    {
        String nomeRegiao;

        public void inserir(String nomeRegiao)
        {
            pRegiao objRegiao = new pRegiao();
            objRegiao.inserir(nomeRegiao);
        }
        public void alterar(String nomeRegiao)
        {

        }
        public void deletar(String nomeRegiao)
        {

        }
        public DataSet consultar()
        {
            pRegiao objRegiao = new pRegiao();
            return objRegiao.consultar();
        }
    }
}
