using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    public class pUsuario
    {
        public String idUsuario { get; set; }
        public void adicionar(String email, String senha, String nome, String cpf, String sexo, String dataNascimento,
                            String ddd, String telefone, String cidade, String estado, String endereco, String complemento, String cep)
        {
            String SQL = "INSERT INTO Usuario(email, senha, nome, cpf, sexo, dataNascimento, ddd, telefone, cidade, estado, endereco, complemento, cep) VALUES('"+ email +"','" + senha + "','" + 
                        nome + "','" + cpf + "','" + sexo + "','" + dataNascimento + "','" + ddd + "','" + telefone + "','" + cidade + "','" + estado + "','" + endereco + "','" + complemento + "','" + cep + "')";
            Conexao objConexao = new Conexao("SQLServer");
            objConexao.executeNoQuery(SQL);
            objConexao.fechaConexao();
        }
        public void alterar(String email, String senha)
        {
            String SQL = "UPDATE Usuario  SET senha = '" + senha + "' WHERE email = '" + email + "'";
            Conexao objConexao = new Conexao("SQLServer");
            objConexao.executeNoQuery(SQL);
            objConexao.fechaConexao();
        }
        public void deletar(String idUsuario)
        {
            String SQL = "DELETE FROM Usuario WHERE idUsuario = '" + idUsuario + "'";
            Conexao objConexao = new Conexao("SQLServer");
            objConexao.executeNoQuery(SQL);
            objConexao.fechaConexao();
        }
        public DataSet consultar()
        {
            String SQL = "SELECT * FROM Usuario";

            Conexao objConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, objConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            objConexao.fechaConexao();
            return ds;
        }
        public void logar(String nomeUsuario, String senha)
        {
            String SQL = "SELECT * FROM Usuarios WHERE nomeUsuario = '" + nomeUsuario
                + "' AND senha= '" + senha + "'";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataReader dr = oConexao.executeReader(SQL);

            while (dr.Read())
            {
                this.idUsuario = Convert.ToString(dr["idUSuario"]);
            }
            dr.Close();

            oConexao.fechaConexao();
        }
    }
}
