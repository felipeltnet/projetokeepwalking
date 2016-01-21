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
    public partial class frmEnviarNewsLetter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            NewsLetter objNewsLetter = new NewsLetter();
            objNewsLetter.enviarEmail(txtEmailOrigin.Text, txtEmailDestino.Text, txtTituloMensagem.Text, txtCorpoMensagem.Text);
        }
    }
}