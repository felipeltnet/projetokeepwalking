using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pRegiao
    {
        String nomeRegiao;

        public void inserir(String nomeRegiao)
        {
            String SQL = "INSERT INTO Regiao(idRegiao, nomeRegiao) VALUES (1, '" + nomeRegiao + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();

        }
        public void alterar(String nomeRegiao)
        {

        }
        public void deletar(String nomeRegiao)
        {

        }
        public void consultar(String nomeRegiao)
        {

        }
    }
}
