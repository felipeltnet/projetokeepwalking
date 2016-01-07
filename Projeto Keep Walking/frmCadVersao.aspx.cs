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
    public partial class frmCadVersao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet lista;
     
            if (!Page.IsPostBack)
            {
                Versao objVersao = new Versao();
                lista = objVersao.consultar();

                if (lista != null)
                {
                    gdvVersao.DataSource = lista;
                    gdvVersao.DataMember = "Tabela";
                    gdvVersao.DataBind();
                }
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Versao objVersao = new Versao();
            objVersao.adicionar(txtVersao.Text);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Versao objVersao = new Versao();
            objVersao.alterar(lblVersao.Text, txtVersao.Text);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Versao objVersao = new Versao();
            objVersao.deletar(lblVersao.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void gdvVersao_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvVersao.SelectedRow;
            lblVersao.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtVersao.Text = Server.HtmlDecode(row.Cells[2].Text);
        }       
        
        }

    }
