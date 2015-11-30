using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
     public class Patrocinador
    {        
        public void adicionar(String nomePatrocinador)
        {
            pPatrocinador objPatrocinador = new pPatrocinador();
            objPatrocinador.adicionar(nomePatrocinador);
        }
        public void deletar(String idPatrocinador)
        {
            pPatrocinador objPatrocinador = new pPatrocinador();
            objPatrocinador.deletar(idPatrocinador);
        }
        public void alterar(String idPatrocinador,String nomePatrocinador)
        {
            pPatrocinador objPatrocinador = new pPatrocinador();
            objPatrocinador.alterar(idPatrocinador, nomePatrocinador);
        }
        public DataSet consultar()
        {
            pPatrocinador objPatrocinador = new pPatrocinador();
            return objPatrocinador.consultar();
        }
    }
}
