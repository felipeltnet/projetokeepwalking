using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Projeto_Keep_Walking
{
    public partial class frmEsqueciMinhaSenha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            objUsuario.verificarEmail(txtEmail.Text);

            NewsLetter objNewsLetter = new NewsLetter();
            objNewsLetter.enviarEmail("felipeltnet@hotmail.com", objUsuario.email, "Recuperação de Senha", "email: " + objUsuario.email + "<br>senha: " + objUsuario.senha);
        }
    }
}