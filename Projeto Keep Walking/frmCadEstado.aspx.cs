using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data.SqlClient;
using System.Data;

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

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Estado objEstado = new Estado();
            objEstado.deletar(lblEstado.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Estado objEstado = new Estado();
            objEstado.alterar(lblEstado.Text, txtEstado.Text);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvEstado.SelectedRow;
            lblEstado.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtEstado.Text = Server.HtmlDecode(row.Cells[2].Text);
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {

        }   
                
    }
}