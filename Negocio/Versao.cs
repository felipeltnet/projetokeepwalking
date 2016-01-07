using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Persistencia;

namespace Negocio
{
    public class Versao
    {

        String nomeVersao;

        public void adicionar(String nomeVersao)
        {
            pVersao objVersao = new pVersao();
            objVersao.adicionar(nomeVersao);
        }
        public void deletar(String idVersao)
        {
            pVersao objVersao = new pVersao();
            objVersao.deletar(idVersao);
        }
        public void alterar(String idVersao, String nomeVersao)
        {
            pVersao objVersao = new pVersao();
            objVersao.alterar(idVersao, nomeVersao);
        }
        public DataSet consultar()
        {
            pVersao objVersao = new pVersao();
            return objVersao.consultar();
        }
    }
}
