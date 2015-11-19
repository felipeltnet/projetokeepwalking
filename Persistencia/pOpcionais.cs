using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    public class pOpcionais
    {        String nomeOpcionais;

        public void adicionar(String nomeOpcionais)
        {
            String SQL = "INSERT INTO Marca(nomeOpcionais) VALUES('" + nomeOpcionais + "')";
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
