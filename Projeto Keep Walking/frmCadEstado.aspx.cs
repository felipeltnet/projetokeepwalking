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
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Estado objEstado = new Estado();
                lista = objEstado.consultar();

                if (lista != null)
                {
                    gdvEstado.DataSource = lista;
                    gdvEstado.DataMember = "Tabela";
                    gdvEstado.DataBind();
                }
            }
        }
        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Estado objEstado = new Estado();
            objEstado.adicionar(lblEstado.Text, txtEstado.Text);
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

        protected void gdvEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvEstado.SelectedRow;
            lblEstado.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtEstado.Text = Server.HtmlDecode(row.Cells[2].Text);
        }

                
    }
}