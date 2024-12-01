using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpPromo_1B
{
    public partial class SeleccionPremio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarArticulos();

            }

        }


        private void cargarArticulos()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(
                    "SELECT TOP 3 a.Id, a.Nombre, a.Descripcion, i.ImagenUrl FROM ARTICULOS a LEFT JOIN IMAGENES i ON a.Id = i.IdArticulo ");
                datos.ejecutarLectura();

                int cont = 0;
                while (datos.Lector.Read())
                {
                    string nombreArticulo = (string)datos.Lector["Nombre"];
                    string descripcionArticulo = (string)datos.Lector["Descripcion"];
                    string imagenUrl = (string)datos.Lector["ImagenUrl"];

                    //if (cont == 0)
                    //{
                    //    lblNombre1.Text = nombreArticulo;
                    //    lblDesc1.Text = descripcionArticulo;
                    //    img1.Src = imagenUrl; 
                    //}
                    //else if (cont == 1)
                    //{
                    //    lblNombre2.Text = nombreArticulo;
                    //    lblDesc2.Text = descripcionArticulo;
                    //    img2.Src = imagenUrl;
                    //}
                    //else if (cont == 2)
                    //{
                    //    lblNombre3.Text = nombreArticulo;
                    //    lblDesc3.Text = descripcionArticulo;
                    //    img3.Src = imagenUrl;
                    //}

                    cont++;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}