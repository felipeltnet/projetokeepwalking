using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pMarca
    {
        String nomeMarca;

        public void adicionar(String nomeMarca)
        {
            String SQL = "INSERT INTO Marca(nomeMarca) VALUES('"+nomeMarca+"')";
            Conexao objConexao = new Conexao("SQLServer");
            objConexao.executeNoQuery(SQL);
            objConexao.fechaConexao();
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
