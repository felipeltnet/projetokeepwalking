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
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                Regiao oRegiao = new Regiao();
                lista = oRegiao.consultar();
                if(lista != null)                
                {
                    gdvRegiao.DataSource = lista;
                    gdvRegiao.DataMember = "Tabela";
                    gdvRegiao.DataBind();
                }
            }
        }
        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Regiao objRegiao = new Regiao();
            objRegiao.inserir(txtRegiao.Text);
        }
    }
}