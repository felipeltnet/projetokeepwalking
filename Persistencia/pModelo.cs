using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia

{
    public class pModelo
    {
        String modelo;
        String marca;
        String descricao;

        public void inserir(String modelo, String marca, String descricao)
        {
            String SQL = "INSERT INTO Modelo(modelo, marca, descricao) VALUES (" + modelo +", '" + marca + "', '" + descricao+"')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void alterar()
        {

        }

        public void apagar()
        {

        }

        public Object consultarTodos()
        {
            return 1;
        }

        public String buscar_CPF()
        {
            return "";
        }

        public int calcularIdade()
        {
            return 1;
        }


    }
}
