using Dominio;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
                    "SELECT TOP 3 Id, Nombre, Descripcion FROM ARTICULOS");
                datos.ejecutarLectura();

                List<string> imagenes1 = new List<string>();
                List<string> imagenes2 = new List<string>();
                List<string> imagenes3 = new List<string>();

                int cont = 0;
                while (datos.Lector.Read())
                {
                    string nombreArticulo = (string)datos.Lector["Nombre"];
                    string descripcionArticulo = (string)datos.Lector["Descripcion"];

                    List<string> imagenesArticulo = obtenerImagenes((int)datos.Lector["Id"]);

                    if (cont == 0)
                    {
                        lblNombre1.Text = nombreArticulo;
                        lblDesc1.Text = descripcionArticulo;
                        imagenes1 = imagenesArticulo;
                    }
                    else if (cont == 1)
                    {
                        lblNombre2.Text = nombreArticulo;
                        lblDesc2.Text = descripcionArticulo;
                        imagenes2 = imagenesArticulo;
                    }
                    else if (cont == 2)
                    {
                        lblNombre3.Text = nombreArticulo;
                        lblDesc3.Text = descripcionArticulo;
                        imagenes3 = imagenesArticulo;
                    }

                    cont++;
                }

                Session["Imagenes1"] = imagenes1;
                Session["Imagenes2"] = imagenes2;
                Session["Imagenes3"] = imagenes3;
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
        private List<string> obtenerImagenes(int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            List<string> imagenes = new List<string>();

            try
            {
                datos.setearConsulta("SELECT ImagenUrl FROM IMAGENES WHERE IdArticulo = @idArticulo");
                datos.setearParametro("@idArticulo", idArticulo);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    imagenes.Add((string)datos.Lector["ImagenUrl"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return imagenes;
        }
        private int buscarId(string nombre)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select id from articulos where nombre=@nombre");
                datos.setearParametro("nombre", nombre);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    articulo = (int)datos.Lector["id"];
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
            if (articulo != 0 && !string.IsNullOrEmpty(codigo))
            {

                Response.Redirect($"RegistroCliente.aspx?idArticulo={articulo}&codigo={codigo}");
            }
        }
        protected void btnPremio2_click(object sender, EventArgs e)
        {
            string nombre = lblNombre2.Text;
            articulo = buscarId(nombre);
            codigo = Request.QueryString["codigo"];
            if (articulo != 0 && !string.IsNullOrEmpty(codigo))
            {
                Response.Redirect($"registrocliente.aspx?idarticulo={articulo}&codigo={codigo}");
            }
        }
        protected void btnPremio3_Click(object sender, EventArgs e)
        {
            string nombre = lblNombre3.Text;
            articulo = buscarId(nombre);
            codigo = Request.QueryString["codigo"];
            if (articulo != 0 && !string.IsNullOrEmpty(codigo))
            {
                Response.Redirect($"RegistroCliente.aspx?idArticulo={articulo}&codigo={codigo}");
            }
        }





    }
}