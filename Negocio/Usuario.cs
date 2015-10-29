using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    class Usuario
    {
        int idUsuario;
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

        public void adicionar(String email, String senha, String nome)
        {
            pUsuario objUsuario = new pUsuario();
            objUsuario.adicionar(email, senha, nome);
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
