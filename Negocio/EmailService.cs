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
            email.Body = "  <style>\r\n        body {\r\n            font-family: Arial, sans-serif;\r\n            text-align: center;\r\n            background-color: #f7f9fc;\r\n            color: #333;\r\n            padding: 20px;\r\n        }\r\n        .container {\r\n            background-color: #ffffff;\r\n            border-radius: 10px;\r\n            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);\r\n            max-width: 600px;\r\n            margin: 50px auto;\r\n            padding: 20px;\r\n        }\r\n        h1 {\r\n            color: #4CAF50;\r\n            font-size: 2.5em;\r\n            margin-bottom: 10px;\r\n        }\r\n        p {\r\n            font-size: 1.2em;\r\n            line-height: 1.6;\r\n        }\r\n        .button {\r\n            display: inline-block;\r\n            margin-top: 20px;\r\n            padding: 10px 20px;\r\n            font-size: 1em;\r\n            color: #ffffff;\r\n            background-color: #4CAF50;\r\n            text-decoration: none;\r\n            border-radius: 5px;\r\n            transition: background-color 0.3s;\r\n        }\r\n        .button:hover {\r\n            background-color: #45a049;\r\n        }\r\n    </style><div class=\"container\">\r\n        <h1>🎉 ¡Felicitaciones!, ya te registramos y estas participando 🎉</h1>\r\n        <p>         En nombre de todo nuestro equipo, queremos agradecerte por tu participación.            Te deseamos mucha suerte y gracias por elegirnos  </p>  </div>";
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