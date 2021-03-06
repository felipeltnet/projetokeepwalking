﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;

namespace Projeto_Keep_Walking
{
    public partial class frmCadUsuario : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Usuario objUsuario = new Usuario();
                lista = objUsuario.consultar();

                if (lista != null)
                {
                    gdvUsuario.DataSource = lista;
                    gdvUsuario.DataMember = "Tabela";
                    gdvUsuario.DataBind();
                }
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            objUsuario.adicionar(txtEmail.Text, txtSenha.Text, txtNome.Text, txtCPF.Text, txtSexo.Text, txtDataNascimento.Text,
                                txtDDD.Text, txtTelefone.Text, txtCidade.Text, txtEstado.Text, txtEndereco.Text, txtComplemento.Text,
                                txtCEP.Text);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            objUsuario.deletar(lblidUsuario.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void gdvUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvUsuario.SelectedRow;
            txtNome.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtEmail.Text = Server.HtmlDecode(row.Cells[2].Text);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            objUsuario.alterar(lblidUsuario.Text, txtSenha.Text);
            Response.Redirect(Request.RawUrl);
        }
    }
}