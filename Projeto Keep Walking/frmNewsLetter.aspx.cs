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
    public partial class frmNewsLetter : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                NewsLetter objNewsLetter = new NewsLetter();
                lista = objNewsLetter.consultar();

                if (lista != null)
                {
                    gdvNewsLetter.DataSource = lista;
                    gdvNewsLetter.DataMember = "Tabela";
                    gdvNewsLetter.DataBind();
                }
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            NewsLetter objNewsLetter = new NewsLetter();
            objNewsLetter.adicionar(txtEmail.Text);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            NewsLetter objNewsLetter = new NewsLetter();
            objNewsLetter.alterar(txtidEmail.Text);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            NewsLetter objNewsLetter = new NewsLetter();
            objNewsLetter.alterar(txtidEmail.Text);
        }

        protected void gdvNewsLetter_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvNewsLetter.SelectedRow;
            txtidEmail.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtEmail.Text = Server.HtmlDecode(row.Cells[2].Text);
        }

    }
}