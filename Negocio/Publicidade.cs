using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
   public class Publicidade
    { 
        String dataInicial;
        String dataFinal;
        String Valor;

        public void adicionar( String dataInicial, String dataFinal, String Valor)
        {
            pPublicidade objPublicidade = new pPublicidade();
            objPublicidade.adicionar(dataInicial, dataFinal, Valor);
        }
        public void deletar(String lblPublicidade)
        {
            pPublicidade objPublicidade = new pPublicidade();
            objPublicidade.deletar(lblPublicidade);
        }
        public void alterar(String dataInicial, String dataFinal, String Valor)
        {
            pPublicidade objPublicidade = new pPublicidade();
            objPublicidade.alterar(dataInicial, dataFinal, Valor);
        }
        public DataSet consultar()
        {
            pPublicidade objPublicidade = new pPublicidade();
            return objPublicidade.consultar();
        }
    }
    }

