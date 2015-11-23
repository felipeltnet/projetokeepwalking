using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Projeto_Keep_Walking
{
    public partial class frmPatrocinador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Patrocinador objPatrocinador = new Patrocinador();
            objPatrocinador.adicionar(txtPatrocinador.Text);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvPatrocinador.SelectedRow;
            lblPatrocinador.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtPatrocinador.Text = Server.HtmlDecode(row.Cells[2].Text);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Patrocinador objPatrocinador = new Patrocinador();
            objPatrocinador.alterar(lblPatrocinador.Text, txtPatrocinador.Text);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Patrocinador objPatrocinador = new Patrocinador();
            objPatrocinador.deletar(lblPatrocinador.Text);
            Response.Redirect(Request.RawUrl);
        }
    }
}