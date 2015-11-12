using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Projeto_Keep_Walking
{
    public partial class frmCadEstado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Estado objEstado = new Estado();
            objEstado.adicionar(txtEstado.Text);
        }
    }
}