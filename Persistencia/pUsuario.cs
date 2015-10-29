using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pUsuario
    {
        String email;
        String nome;
        String senha;

        public void adicionar(String email, String senha, String nome)
        {
            String SQL = "INSERT INTO () VALUES()";
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
