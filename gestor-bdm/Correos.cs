using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace gestor_bdm
{
    class Correos
    {
        /*
         * Cliente SMTP
         * Gmail:  smtp.gmail.com  puerto:587
         * Hotmail: smtp.liva.com  puerto:25
         */
        SmtpClient server = new SmtpClient("smtp.gmail.com", 587);

        public Correos()
        {
            /*
             * Autenticacion en el Servidor
             * Utilizaremos nuestra cuenta de correo
             *
             * Direccion de Correo (Gmail o Hotmail)
             * y Contrasena correspondiente
             */
            server.Credentials = new System.Net.NetworkCredential("pablochay89@gmail.com", "Chay1318");
            server.EnableSsl = true;
        }

        public void MandarCorreo(MailMessage mensaje)
        {
            server.Send(mensaje);
        }
    }
}
