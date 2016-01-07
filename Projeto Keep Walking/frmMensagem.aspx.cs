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
    public partial class frmMensagem : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Mensagem objMensagem = new Mensagem();
                lista = objMensagem.consultar();

                if (lista != null)
                {
                    gdvMensagem.DataSource = lista;
                    gdvMensagem.DataMember = "Tabela";
                    gdvMensagem.DataBind();
                }
            }
        }        

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Mensagem objMensagem = new Mensagem();
            objMensagem.deletar(lblMensagem.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Mensagem objMensagem = new Mensagem();
            objMensagem.alterar(lblMensagem.Text,txtAssunto.Text, txtMensagem.Text);
        }
        protected void btnAdicionar_Click1(object sender, EventArgs e)
        {
            Mensagem objMensagem = new Mensagem();
            objMensagem.adicionar(txtMensagem.Text, txtAssunto.Text);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvMensagem.SelectedRow;
            lblMensagem.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtMensagem.Text = Server.HtmlDecode(row.Cells[2].Text);
            txtAssunto.Text = Server.HtmlDecode(row.Cells[3].Text);
        }
    }
}