﻿using System;
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

        }

        protected void btnVoucher_Click(object sender, EventArgs e)
        {
            Response.Redirect("SeleccionPremio.aspx");
        }
    }
}