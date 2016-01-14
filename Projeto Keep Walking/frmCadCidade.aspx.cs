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
    public partial class frmCadCidade : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Cidade objCidade = new Cidade();
                lista = objCidade.consultar();

                if (lista != null)
                {
                    gdvCidade.DataSource = lista;
                    gdvCidade.DataMember = "Tabela";
                    gdvCidade.DataBind();
                }
            }
        }

        protected void lblAdicionar_Click(object sender, EventArgs e)
        {
            Cidade objCidade = new Cidade();
            objCidade.adicionar(txtCidade.Text);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Cidade objCidade = new Cidade();
            objCidade.alterar(lblCidade.Text, txtCidade.Text);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {

            Cidade objCidade = new Cidade();
            objCidade.deletar(lblCidade.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void gdvCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvCidade.SelectedRow;
            lblCidade.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtCidade.Text = Server.HtmlDecode(row.Cells[2].Text);
        }
    }
}