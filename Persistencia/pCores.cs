using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pCores
    {
        String nomeCor;

        public void adicionar(String nomeCor)
        {
            String SQL = "INSERT INTO Cores(nomeCor) VALUES ('" +  nomeCor + "')";
            Conexao objConexao = new Conexao("SQLServer");
            objConexao.executeNoQuery(SQL);
            objConexao.fechaConexao();
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
