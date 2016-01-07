using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;

namespace Projeto_Keep_Walking
{
    public partial class frmCadCambio : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Cambio objCambio = new Cambio();
                lista = objCambio.consultarTodos();

                if (lista != null)
                {
                    gdvCambio.DataSource = lista;
                    gdvCambio.DataMember = "Tabela";
                    gdvCambio.DataBind();
                }

            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Cambio objCambio = new Cambio();
            objCambio.inserir(txtCambio.Text);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Cambio objCambio = new Cambio();
            objCambio.alterar(lblCambio.Text, txtCambio.Text);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Cambio objCambio = new Cambio();
            objCambio.deletar(lblCambio.Text);
            Response.Redirect(Request.RawUrl);
        }
        
        protected void gdvModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvCambio.SelectedRow;
            lblCambio.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtCambio.Text = Server.HtmlDecode(row.Cells[2].Text);
        } 
    }
}