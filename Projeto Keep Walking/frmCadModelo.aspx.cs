﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;

namespace WebAppExercicio
{
    public partial class frmCadModelo : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Modelo objModelo = new Modelo();
                lista = objModelo.consultarTodos();

                if (lista != null)
                {
                    gdvModelo.DataSource = lista;
                    gdvModelo.DataMember = "Tabela";
                    gdvModelo.DataBind();
                }

            }
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Modelo objModelo = new Modelo();
            objModelo.inserir(txtDescricao.Text);

        }
    }
}