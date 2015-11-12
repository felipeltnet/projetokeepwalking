using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pCategoria
    {
        String nomeCategoria;

        public void adicionar(String nomeCategoria)
        {
            String SQL = "INSERT INTO Categoria(nomeCategoria) VALUES('" + nomeCategoria + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
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
