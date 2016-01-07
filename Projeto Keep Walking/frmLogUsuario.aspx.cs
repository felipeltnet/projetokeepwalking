using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Projeto_Keep_Walking
{
    public partial class frmLogUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            objUsuario.logar(txtEmail.Text,txtSenha.Text);

            if(objUsuario.idUsuario != null)
            {
                Session["Usuario"] = objUsuario.idUsuario;
                Response.Redirect("index.aspx");
            }
            else 
            {
                Response.Redirect(Request.RawUrl);
            }
        }            
    }
}