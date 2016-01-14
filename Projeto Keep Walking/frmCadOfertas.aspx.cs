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
    public partial class frmCadOfertas : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet lista;
             if (!Page.IsPostBack)
            {
                Ofertas objOfertas = new Ofertas();
                lista = objOfertas.consultar();

                if (lista != null)
                {
                    gdvOfertas.DataSource = lista;
                    gdvOfertas.DataMember = "Tabela";
                    gdvOfertas.DataBind();
                }
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Ofertas objOfertas = new Ofertas();
            objOfertas.adicionar(txtOfertas.Text);
        }

        protected void gdvOfertas_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvOfertas.SelectedRow;
            lblOfertas.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtOfertas.Text = Server.HtmlDecode(row.Cells[2].Text);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Ofertas objOfertas = new Ofertas();
            objOfertas.alterar(lblOfertas.Text, txtOfertas.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Ofertas objOfertas = new Ofertas();
            objOfertas.deletar(lblOfertas.Text);
            Response.Redirect(Request.RawUrl);
        }
        }
    }
