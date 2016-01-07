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
    public partial class frmCadCombustivel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet lista;
            if (!Page.IsPostBack)
            {
                Combustivel objCombustivel = new Combustivel();
                lista = objCombustivel.consultar();

                if (lista != null)
                {
                    gdvCombustivel.DataSource = lista;
                    gdvCombustivel.DataMember = "Tabela";
                    gdvCombustivel.DataBind();
                }
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Combustivel objCombustivel = new Combustivel();
            objCombustivel.adicionar(txtCombustivel.Text);
        }


        protected void gdvCombustivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvCombustivel.SelectedRow;
            lblCombustivel.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtCombustivel.Text = Server.HtmlDecode(row.Cells[2].Text);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Combustivel objCombustivel = new Combustivel();
            objCombustivel.alterar(lblCombustivel.Text, txtCombustivel.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Combustivel objCombustivel = new Combustivel();
            objCombustivel.deletar(lblCombustivel.Text);
            Response.Redirect(Request.RawUrl);
        }
    }
}