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
    public partial class frmCadCores : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {    
            if (!Page.IsPostBack)
            {
                Cores objCores = new Cores();
                lista = objCores.consultar();

                if (lista != null)
                {
                    gdvCores.DataSource = lista;
                    gdvCores.DataMember = "Tabela";
                    gdvCores.DataBind();
                }
            }
        }

        protected void btnAdicionar_Click1(object sender, EventArgs e)
        {
            Cores objCores = new Cores();
            objCores.adicionar(txtNomeCor.Text);
        }
        
        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Cores objCores = new Cores();
            objCores.deletar(lblCores.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Cores objEstado = new Cores();
            objEstado.alterar(lblCores.Text, txtNomeCor.Text);
        }        

        protected void gdvCores_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvCores.SelectedRow;
            lblCores.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtNomeCor.Text = Server.HtmlDecode(row.Cells[2].Text);
        }
                
    }
}