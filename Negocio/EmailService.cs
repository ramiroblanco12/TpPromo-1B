using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Negocio
{
    public class EmailService
    {
        private MailMessage email;
        private SmtpClient server;

        public EmailService()
        {
        server = new SmtpClient();
            server.Credentials = new NetworkCredential("aplicacionprogramacioniii@gmail.com", "crqw tuex lqcn gynd");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "smtp.gmail.com";
        }

        public void armarCorreo (string emailDestino)
        {
            email = new MailMessage();

            email.From = new MailAddress("aplicacionprogramacioniii@gmail.com");
            email.To.Add(emailDestino);

            email.IsBodyHtml=true;
            email.Body = "<h1>Felicitaciones por tu premio</h1>";
        }

        public void enviarmail()
        {
            try
            {
                server.Send(email);
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }

    }
}