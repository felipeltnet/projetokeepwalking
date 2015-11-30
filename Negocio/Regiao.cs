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
        public void adicionar(String nomeRegiao)
        {
            pRegiao objRegiao = new pRegiao();
            objRegiao.adicionar(nomeRegiao);
        }
        public void deletar(String idRegiao)
        {
            pRegiao objRegiao = new pRegiao();
            objRegiao.deletar(idRegiao);
        }
        public void alterar(String idRegiao, String nomeRegiao)
        {
            pRegiao objRegiao = new pRegiao();
            objRegiao.alterar(idRegiao, nomeRegiao);
        }
        public DataSet consultar()
        {
            pRegiao objRegiao = new pRegiao();
            return objRegiao.consultar();
        }
    }
}
