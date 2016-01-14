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
    public partial class frmPublicidade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet lista;
            if (!Page.IsPostBack)
            {
                Publicidade objPublicidade = new Publicidade();
                lista = objPublicidade.consultar();

                if (lista != null)
                {
                    gdvPublicidade.DataSource = lista;
                    gdvPublicidade.DataMember = "Tabela";
                    gdvPublicidade.DataBind();
                }
            }

        }

        protected void gdvPublicidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvPublicidade.SelectedRow;
            lblPublicidade.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtDataInicial.Text = Server.HtmlDecode(row.Cells[2].Text);
            txtDataFinal.Text = Server.HtmlDecode(row.Cells[3].Text);
            txtValor.Text = Server.HtmlDecode(row.Cells[4].Text);
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Publicidade objPublicidade = new Publicidade();
            objPublicidade.adicionar(txtDataInicial.Text, txtDataFinal.Text, txtValor.Text);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Publicidade objPublicidade = new Publicidade();
            objPublicidade.deletar(lblPublicidade.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Publicidade objPublicidade = new Publicidade();
            objPublicidade.alterar(txtDataInicial.Text, txtDataFinal.Text, txtValor.Text);
        }

        
    }
}