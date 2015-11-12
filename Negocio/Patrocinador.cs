using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
     public class Patrocinador
    {
        String nomePatrocinador;


        public void adicionar(String nomePatrocinador)
        {
            pPatrocinador objPatrocinador = new pPatrocinador();
            objPatrocinador.adicionar(nomePatrocinador);
        }
        public void deletar()
        {
        }
        public void alterar()
        {
        }
        public String consultar()
        {
            return "";
        }
    }
}
