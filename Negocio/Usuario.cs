using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
    public class Usuario
    {
        public String idUsuario { get; set; }
        public String email { get; set; }
        public String senha { get; set; }

        public void adicionar(String email, String senha, String nome, String cpf, String sexo, String dataNascimento,
                            String ddd, String telefone, String cidade, String estado, String endereco, String complemento, String cep)
        {
            pUsuario objUsuario = new pUsuario();
            objUsuario.adicionar(email, senha, nome, cpf, sexo, dataNascimento, ddd, telefone, cidade, estado, endereco, complemento, cep);
        }
        public void alterar(String idUsuario, String senha)
        {
            pUsuario objUsuario = new pUsuario();
            objUsuario.alterar(idUsuario, senha);
        }
        public void deletar(String idUsuario)
        {
            pUsuario objUsuario = new pUsuario();
            objUsuario.deletar(idUsuario);
        }
        public DataSet consultar()
        {
            pUsuario objUsuario = new pUsuario();
            return objUsuario.consultar();
        }
        public void logar(String email, String senha)
        {
            pUsuario objUsuario = new pUsuario();
            objUsuario.logar(email, senha);
            this.idUsuario = objUsuario.idUsuario;
        }
        public void verificarEmail(String email)
        {
            pUsuario objUsuario = new pUsuario();
            objUsuario.verificarEmail(email);
            this.idUsuario = objUsuario.idUsuario;
            this.email = objUsuario.email;
            this.senha = objUsuario.senha;
        }
    }    
}
