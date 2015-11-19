using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Projeto_Keep_Walking
{
    public partial class frmOpcionais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }   
        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Opcionais objOpcionais = new Opcionais();
            objOpcionais.adicionar(txtOpcionais.Text);
        }
    }
}