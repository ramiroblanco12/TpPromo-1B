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
            if (negocio.buscar(codigo))
            {
                string script = "alert('Voucher valido');";
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
            Response.Redirect("SeleccionPremio.aspx");
            }
            else {
                string script = "alert('No encontrado');";
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
            }
        }
    }
}