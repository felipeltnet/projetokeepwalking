using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Projeto_Keep_Walking
{
    public partial class frmCadMarca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Marca objMarca = new Marca();
            objMarca.adicionar(txtNomeMarca.Text);
        }
    }
}