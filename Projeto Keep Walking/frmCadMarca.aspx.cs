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
    public partial class frmCadMarca : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Marca objMarca = new Marca();
                lista = objMarca.consultar();

                if (lista != null)
                {
                    gdvMarca.DataSource = lista;
                    gdvMarca.DataMember = "Tabela";
                    gdvMarca.DataBind();
                }
            }

        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Marca objMarca = new Marca();
            objMarca.adicionar(txtIdCategoria.Text , txtNomeMarca.Text);
        }

        protected void gdvMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvMarca.SelectedRow;
            lblMarca.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtNomeMarca.Text = Server.HtmlDecode(row.Cells[2].Text);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Marca objMarca = new Marca();
            objMarca.alterar(lblMarca.Text, txtNomeMarca.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {   Marca objMarca = new Marca();
            objMarca.deletar(lblMarca.Text);
            Response.Redirect(Request.RawUrl);
        }
    }
}