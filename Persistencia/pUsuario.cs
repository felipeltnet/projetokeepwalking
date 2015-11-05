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
        String senha;
        String nome;
        int cpf;
        String sexo;
        DateTime dataNascimento;
        int telefone;
        String cidade;
        String estado;
        String endereco;
        String complemento;
        int cep;
        int ddd;

        public void adicionar(String email, String senha, String nome, int cpf, String sexo, DateTime dataNascimento,
                            int ddd, int telefone, String cidade, String estado, String endereco, String complemento, int cep)
        {
            String SQL = "INSERT INTO Usuario(email, senha, nome, cpf, sexo, dataNascimento, ddd, telefone, cidade, estado, endereco, complemento, cep) VALUES('"+ email +"," + senha + "," + 
                        nome + "," + cpf + "," + sexo + "," + dataNascimento + "," + ddd + "," + telefone + "," + cidade + "," + estado + "," + endereco + "," + complemento + "," + cep + "')";
            Conexao objConexao = new Conexao("SQLServer");
            objConexao.executeNoQuery(SQL);
            objConexao.fechaConexao();
        }
        public void alterar()
        {

        }
        public void deletar(String email, String senha)
        {
            String SQL = "DELETE FROM Usuario WHERE email = '" + email + "' AND senha = '" + senha + "'";
            Conexao objConexao = new Conexao("SQLServer");
            objConexao.executeNoQuery(SQL);
            objConexao.fechaConexao();
        }
        public String consultar()
        {
            return "";
        }
    }
}
