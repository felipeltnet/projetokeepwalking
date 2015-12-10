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
    public partial class frmCadRegiao : System.Web.UI.Page
    {        
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Regiao objRegiao = new Regiao();
                lista = objRegiao.consultar();

                if (lista != null)
                {
                    gdvRegiao.DataSource = lista;
                    gdvRegiao.DataMember = "Tabela";
                    gdvRegiao.DataBind();
                }
            }
        }

        protected void btnAdicionar_Click1(object sender, EventArgs e)
        {
            Regiao objRegiao = new Regiao();
            objRegiao.adicionar(txtRegiao.Text);
        }
                   
        protected void btnDeletar_Click1(object sender, EventArgs e)
        {
            Regiao objRegiao = new Regiao();
            objRegiao.deletar(lblRegiao.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnAlterar_Click1(object sender, EventArgs e)
        {
            Regiao objRegiao = new Regiao();
            objRegiao.alterar(lblRegiao.Text, txtRegiao.Text);
        }

        protected void gdvRegiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvRegiao.SelectedRow;
            lblRegiao.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtRegiao.Text = Server.HtmlDecode(row.Cells[2].Text);
        }        
    }
}