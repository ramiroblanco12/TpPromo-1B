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
    public partial class SeleccionPremio : System.Web.UI.Page
    {
        public int articulo { get; set; }
        public string codigo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarArticulos();
                if (!string.IsNullOrEmpty(Request.QueryString["codigo"]))
                {
                     codigo = Request.QueryString["codigo"];
                    
                }

            }

        }


        private void cargarArticulos()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(
                    "SELECT TOP 3 Id, Nombre, Descripcion FROM ARTICULOS ");
                datos.ejecutarLectura();

                int cont = 0;
                while (datos.Lector.Read())
                {
                    string nombreArticulo = (string)datos.Lector["Nombre"];
                    string descripcionArticulo = (string)datos.Lector["Descripcion"];


                    if (cont == 0)
                    {
                        lblNombre1.Text = nombreArticulo;
                        lblDesc1.Text = descripcionArticulo;
                        
                    }
                    else if (cont == 1)
                    {
                        lblNombre2.Text = nombreArticulo;
                        lblDesc2.Text = descripcionArticulo;

                    }
                    else if (cont == 2)
                    {
                        lblNombre3.Text = nombreArticulo;
                        lblDesc3.Text = descripcionArticulo;

                    }

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
        private int buscarId(string nombre)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id from Articulos where Nombre=@nombre");
                datos.setearParametro("nombre", nombre);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    articulo = (int)datos.Lector["Id"];
                    return articulo;
                }
                articulo = 0;
                return articulo;
            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.cerrarConexion(); }
        }

        protected void btnPremio1_Click(object sender, EventArgs e)
        {
            string nombre = lblNombre1.Text;
            articulo = buscarId(nombre);
            codigo = Request.QueryString["codigo"];
            if (articulo != 0&& !string.IsNullOrEmpty(codigo))
            {
                
                Response.Redirect($"RegistroCliente.aspx?idArticulo={articulo}&codigo={codigo}");
            }
        }
        protected void btnPremio2_Click(object sender, EventArgs e)
        {
            string nombre = lblNombre2.Text;
            articulo = buscarId(nombre);
            if (articulo != 0)
            {
                Response.Redirect($"RegistroCliente.aspx?idArticulo={articulo}&codigo={codigo}");
            }
        }
        protected void btnPremio3_Click(object sender, EventArgs e)
        {
            string nombre = lblNombre3.Text;
            articulo = buscarId(nombre);
            if (articulo != 0)
            {
                Response.Redirect($"RegistroCliente.aspx?idArticulo={articulo}&codigo={codigo}");
            }
        }
    }
}