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
        protected void Page_Load(object sender, EventArgs e)
        {

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
        emailService.enviarmail();
        lblError.Text = "Correo enviado correctamente.";
        lblError.Visible = true;
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

    }
}