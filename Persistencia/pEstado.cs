using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
     public class pEstado
    {

        String estado;

        public void adicionar(String estado)
        {
            String SQL = "INSERT INTO Estado(idEstado, idRegiao, estado) VALUES(1,1 '" + estado + "')";
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
