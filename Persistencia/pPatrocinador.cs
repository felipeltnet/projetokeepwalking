using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pPatrocinador
    {
        String nomePatrocinador;

        public void adicionar(String nomePatrocinador)
        {
            String SQL = "INSERT INTO Patrocinadores(nomePatrocinador) VALUES('" + nomePatrocinador + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void alterar()
        {

        }
        public void deletar()
        {

        }
        public String consultar()
        {
            return "";
        }
    }
}
