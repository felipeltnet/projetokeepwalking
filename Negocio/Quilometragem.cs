using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Persistencia;

namespace Negocio
{
   public class Quilometragem
   {
       String quilometragem;

       public void adicionar(String quilometragem)
       {
           pQuilometragem objQuilometragem = new pQuilometragem();
           objQuilometragem.adicionar(quilometragem);
       }
       public void deletar(String idQuilometragem)
       {
           pQuilometragem objQuilometragem = new pQuilometragem();
           objQuilometragem.deletar(idQuilometragem);
       }
       public void alterar(String idQuilometragem, String quilometragem)
       {
           pQuilometragem objQuilometragem = new pQuilometragem();
           objQuilometragem.alterar(idQuilometragem, quilometragem);
       }
       public DataSet consultar()
       {
           pQuilometragem objQuilometragem = new pQuilometragem();
           return objQuilometragem.consultar();
       }
   }
}
