using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;

namespace WebAppExercicio
{
    public partial class frmCadModelo : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Modelo objModelo = new Modelo();
                lista = objModelo.consultarTodos();

                if (lista != null)
                {
                    gdvModelo.DataSource = lista;
                    gdvModelo.DataMember = "Tabela";
                    gdvModelo.DataBind();
                }

            }
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Modelo objModelo = new Modelo();
            objModelo.inserir(txtDescricao.Text);

        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Modelo objModelo = new Modelo();
            objModelo.deletar(lblModelo.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Modelo objModelo = new Modelo();
            objModelo.alterar(lblModelo.Text, txtDescricao.Text);
        }

        protected void gdvModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvModelo.SelectedRow;
            lblModelo.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtDescricao.Text = Server.HtmlDecode(row.Cells[2].Text);
        }        
    }
}