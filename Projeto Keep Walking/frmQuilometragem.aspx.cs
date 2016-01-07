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
    public partial class frmQuilometragem : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Quilometragem objQuilometragem = new Quilometragem();
                lista = objQuilometragem.consultar();

                if (lista != null)
                {
                    gdvQuilometragem.DataSource = lista;
                    gdvQuilometragem.DataMember = "Tabela";
                    gdvQuilometragem.DataBind();
                }
            }
        }


        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Quilometragem objQuilometragem = new Quilometragem();
            objQuilometragem.adicionar(txtQuilometragem.Text);

        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {

            Quilometragem objQuilometragem = new Quilometragem();
            objQuilometragem.deletar(lblQuilometragem.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Quilometragem objQuilometragem = new Quilometragem();
            objQuilometragem.alterar(lblQuilometragem.Text, txtQuilometragem.Text);
            Response.Redirect(Request.RawUrl);

        }

        protected void gdvQuilometragem_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvQuilometragem.SelectedRow;
            lblQuilometragem.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtQuilometragem.Text = Server.HtmlDecode(row.Cells[2].Text);
        }

       
        }
    }
