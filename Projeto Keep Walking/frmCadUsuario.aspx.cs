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
            objUsuario.adicionar(txtEmail.Text, txtSenha.Text, txtNome.Text, Convert.ToInt16(txtCPF), txtSexo.Text, Convert.ToDateTime(txtDataNascimento),
                                Convert.ToInt16(txtDDD), Convert.ToInt16(txtTelefone), txtCidade.Text, txtEstado.Text, txtEndereco.Text, txtComplemento.Text,
                                Convert.ToInt16(txtCEP));
        }
    }
}