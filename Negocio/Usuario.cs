using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class Usuario
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
            pUsuario objUsuario = new pUsuario();
            objUsuario.adicionar(email, senha, nome, cpf, sexo, dataNascimento, ddd, telefone, cidade, estado, endereco, complemento, cep);
        }
        public void alterar()
        {

        }
        public void deletar(String email, String senha)
        {
            pUsuario objUsuario = new pUsuario();
            objUsuario.deletar(email, senha);
        }
        public String consultar(String email, String senha)
        {
            return "";
        }
    }

}
