﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;


namespace Projeto_Keep_Walking
{
    public partial class frmMensagem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Mensagem objMensgem = new Mensagem();
            objMensgem.adicionar(txtUsuario.Text, txtMensagem.Text, txtAssunto.Text);
        }
    }
}