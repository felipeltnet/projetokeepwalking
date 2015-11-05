using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Projeto_Keep_Walking
{
    public partial class frmCadUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            objUsuario.adicionar(txtEmail.Text, txtSenha.Text, txtNome.Text, txtCPF.Text, txtSexo.Text, txtDataNascimento.Text,
                                txtDDD.Text, txtTelefone.Text, txtCidade.Text, txtEstado.Text, txtEndereco.Text, txtComplemento.Text,
                                txtCEP.Text);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            objUsuario.deletar(txtEmail.Text, txtSenha.Text);
        }
    }
}