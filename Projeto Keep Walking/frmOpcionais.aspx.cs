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
    public partial class frmOpcionais : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Opcionais objOpcionais = new Opcionais();
                lista = objOpcionais.consultar();

                if (lista != null)
                {
                    gdvOpcionais.DataSource = lista;
                    gdvOpcionais.DataMember = "Tabela";
                    gdvOpcionais.DataBind();
                }
            }
        }
        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Opcionais objOpcionais = new Opcionais();
            objOpcionais.adicionar(txtOpcionais.Text);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Opcionais objOpcionais = new Opcionais();
            objOpcionais.deletar(lblOpcionais.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Opcionais objOpcionais = new Opcionais();
            objOpcionais.alterar(lblOpcionais.Text, txtOpcionais.Text);
        }
       
        protected void gdvOpcionais_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvOpcionais.SelectedRow;
            lblOpcionais.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtOpcionais.Text = Server.HtmlDecode(row.Cells[2].Text);
        }

        
    }
}