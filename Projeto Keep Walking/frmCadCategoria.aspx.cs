using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Negocio;

namespace Projeto_Keep_Walking
{
    public partial class frmCadCategoria : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Categoria objCategoria = new Categoria();
                lista = objCategoria.consultar();

                if (lista != null)
                {
                    gdvCategoria.DataSource = lista;
                    gdvCategoria.DataMember = "Tabela";
                    gdvCategoria.DataBind();
                }
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            objCategoria.adicionar(txtNomeCategoria.Text);
        }

        protected void gdvCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvCategoria.SelectedRow;
            lblCategoria.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtNomeCategoria.Text = Server.HtmlDecode(row.Cells[2].Text);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            objCategoria.alterar(lblCategoria.Text, txtNomeCategoria.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            objCategoria.deletar(lblCategoria.Text);
            Response.Redirect(Request.RawUrl);
        }
    }
}