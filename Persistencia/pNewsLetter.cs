using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pNewsLetter
    {
        String email;

        public void adicionar(String email)
        {
            String SQL = "INSERT INTO NewsLetter(email) VALUES('" + email +"')";
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
