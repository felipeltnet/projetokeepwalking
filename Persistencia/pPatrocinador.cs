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
        public void alterar(String idPatrocinador, String nomePatrocinador)
        {
            String SQL = "UPDATE Patrocinador" + " SET nomePatrocinador = '" + nomePatrocinador + "' WHERE idPatrocinador = '" + idPatrocinador + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void deletar(String idPatrocinador)
        {
            String SQL = "DELETE Patrocinadores WHERE idPatrocinador = "+ idPatrocinador;
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public String consultar()
        {
            return "";
        }
    }
}
