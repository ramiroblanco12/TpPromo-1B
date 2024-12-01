using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpPromo_1B
{
    public partial class IngresoCodigo : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }


        protected void btnVoucher_Click(object sender, EventArgs e)
        {
            VoucherNegocio negocio = new VoucherNegocio();
            string codigo = txtVoucher.Text;
            bool usado = false;
            if (negocio.buscar(codigo, ref usado))
            {
                if (usado)
                {
                    string script = "alert('Voucher ya utilizado');";
                    ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
                }
                else
                {
                    Response.Redirect($"SeleccionPremio.aspx?codigo={codigo}");


                }
            }
            else
            {
                string script = "alert('No encontrado');";
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
            }
        }
    }
}