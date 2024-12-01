using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpPromo_1B
{
    public partial class RegistroCliente : System.Web.UI.Page
    {
        public bool valido { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int idArticulo = 0;
                string codigoVoucher = string.Empty;
                txtArticulo.Visible = false;
                txtCodV.Visible = false;
                valido = false;
                if (!string.IsNullOrEmpty(Request.QueryString["idArticulo"]))
                {
                    
                    if (int.TryParse(Request.QueryString["idArticulo"], out idArticulo))
                    {

                        txtArticulo.Text = idArticulo.ToString();
                    }
                    else
                    {
                        //lblError1.Text = "El ID del artículo no es válido.";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    //lblError1.Text = "No se envió ningún ID de artículo.";
                    lblError.Visible = true;
                }
                if (!string.IsNullOrEmpty(Request.QueryString["codigo"]))
                {
                    codigoVoucher = Request.QueryString["codigo"];
                        txtCodV.Text=codigoVoucher.ToString();
                }
                else
                {
                    lblError1.Text = "No se envió ningún codigo de voucher. ";
                    lblError.Visible = true;
                }

            }

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {

            string emailDestino = txtEmail.Text.Trim();

            // Verificar si el valor del TextBox está vacío o no es válido
            if (string.IsNullOrEmpty(emailDestino) || !IsValidEmail(emailDestino))
            {
                lblError.Text = "La dirección de correo ingresada no es válida.";
                lblError.Visible = true;
                return;
            }

            EmailService emailService = new EmailService();
            emailService.armarCorreo(emailDestino);

            try
            {
                cargar();
                emailService.enviarmail();
                lblEnviado.Text = "Correo enviado correctamente.";
                lblEnviado.Visible = true;
            }
            catch (Exception ex)
            {
                lblError.Text = "Error al enviar el correo: " + ex.Message;
                lblError.Visible = true;
            }
        }

        // Método auxiliar para validar correos electrónicos
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool validarDni()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                int dni = int.Parse(txtDni.Text);
                datos.setearConsulta("SELECT Id,Documento,Nombre,Apellido,Email,Direccion,Ciudad,CP FROM Clientes WHERE Documento = @Documento");
                datos.setearParametro("@Documento", dni);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    txtDni.Enabled = false;
                    txtNombre.Text = (string)datos.Lector["Nombre"];
                    txtNombre.Enabled = false;
                    txtApellido.Text = (string)datos.Lector["Apellido"];
                    txtApellido.Enabled = false;
                    txtEmail.Text = (string)datos.Lector["Email"];
                    txtEmail.Enabled = false;
                    txtDireccion.Text = (string)datos.Lector["Direccion"];
                    txtDireccion.Enabled = false;
                    txtCiudad.Text = (string)datos.Lector["Ciudad"];
                    txtCiudad.Enabled = false;
                    txtCP.Text = datos.Lector["CP"].ToString();
                    txtCP.Enabled = false;




                    return true;

                }

                return false;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        protected void btnValidaDni_Click(object sender, EventArgs e)
        {
            if (validarDni())
            {
                valido = true;
                btnValidaDni.Visible = false;

            }
            else
            {
                valido = true;
                btnValidaDni.Visible = false;
            }
        }
        private void cargar()
        {
            AccesoDatos datos = new AccesoDatos();
            AccesoDatos voucher = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Clientes(Documento,Nombre,Apellido,Email,Direccion,Ciudad,CP) OUTPUT INSERTED.Id VALUES (@Documento,@Nombre,@Apellido,@Email,@Direccion,@Ciudad,@CP)");
                datos.setearParametro("@Documento", txtDni.Text);
                datos.setearParametro("@Nombre", txtNombre.Text);
                datos.setearParametro("@Apellido", txtApellido.Text);
                datos.setearParametro("@Email", txtEmail.Text);
                datos.setearParametro("@Direccion", txtDireccion.Text);
                datos.setearParametro("@Ciudad", txtCiudad.Text);
                datos.setearParametro("@CP", txtCP.Text);
                datos.ejecutarLectura();

                int IdCliente = 0;
                if (datos.Lector.Read())
                {
                    IdCliente = (int)datos.Lector[0];
                }
                voucher.setearConsulta("UPDATE Vouchers SET IdCliente = @IdCliente, FechaCanje = GETDATE(), IdArticulo = @IdArticulo WHERE CodigoVoucher = @CodigoVoucher;");
                voucher.setearParametro("@IdCliente",IdCliente);
                voucher.setearParametro("@IdArticulo",txtArticulo.Text);
                voucher.setearParametro("@CodigoVoucher",txtCodV.Text);
                voucher.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
                voucher.cerrarConexion();
            }

        }
    }
}