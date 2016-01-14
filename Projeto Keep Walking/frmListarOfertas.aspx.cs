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
    public partial class frmListarOfertas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            listarOfertas();
        }
        private void listarOfertas()
        {
            Ofertas pOfertas = new Ofertas();
            DataSet dtOfertas = pOfertas.consultar();

            for (int linha = 0; linha < dtOfertas.Tables["Tabela"].Rows.Count; linha++)
            {
                TableRow tRow = new TableRow();
                tbOfertas.Rows.Add(tRow);

                for (int coluna = 0; coluna < 4; coluna++)
                {
                    TableCell tCell = new TableCell();
                    tCell.Text = Convert.ToString(dtOfertas.Tables["Tabela"].Rows[linha][coluna]);
                    tRow.Cells.Add(tCell);
                }
            }
        }
    }
}