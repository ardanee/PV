using System;
using System.ComponentModel;
using System.Net.Mail;
using System.Windows.Forms;

namespace PV.BL
{
    class Correo
    {
        static bool mailEnviado = false;
        private String mailEmisor = "roonmorton@gmail.com";
        private String mailReceptor = "aaronajin@gmail.com";
        private String nombreDe = "Prueba";
        private String apellidoDe = "Prueba";
        private SmtpClient cliente;
        private MailAddress mailDe;
        private MailAddress mailPara;
        private MailMessage mensaje;
        private string estado;

        private void autenticar()
        {
            this.cliente.Credentials = new System.Net.NetworkCredential("ronquevedo77@gmail.com","680cfb8dac2016");
            this.cliente.EnableSsl = true;
            this.cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            this.cliente.Timeout = 10000;

        }


        public Correo()
        {
            this.cliente = new SmtpClient("smtp.gmail.com",587);
            this.autenticar();   
            this.mailDe = new MailAddress(this.mailEmisor, this.nombreDe + (char)0xD8 + this.apellidoDe,System.Text.Encoding.UTF8);
            this.mailPara = new MailAddress(this.mailReceptor);
            this.mensaje = new MailMessage(this.mailDe,this.mailPara);
            this.estado = "";
        }


        public void enviar()
        {
            
            this.mensaje.Body = "Aaron Gay, estoy probado el envio de correo de la app, se requerira un correo para autenticarse y enviar el mail... algo asi xDD";
            String someArrows = new String(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
            this.mensaje.Body += Environment.NewLine + someArrows;
            this.mensaje.BodyEncoding = System.Text.Encoding.UTF8;
            this.mensaje.Subject = "Prueba mensaje 1 " + someArrows;
            this.mensaje.Attachments.Add(this.generarReporte());
            this.mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
            this.cliente.SendCompleted += new SendCompletedEventHandler(estadoEnvio);

            string userState = "prueba Mensaje1";
            this.cliente.SendAsync(this.mensaje,userState);

            //this.mensaje.Dispose();

        }

        

        private void estadoEnvio(object sender,AsyncCompletedEventArgs e)
        {
            String ficha = (String)e.UserState;

            if (e.Cancelled)
            {
                //Mesnaje Cancelado
                this.estado = "Mensaje cancelado " + ficha + e.Error;
            }
            if (e.Error != null)
            {
                //Error en el Envio
                this.estado = "Error en el envio " + ficha + e.Error;

            }
            else
            {
                //Mensaje Enviado
                this.estado = "Mensaje Enviado " + ficha;

            }
            MessageBox.Show(this.estado);
            mailEnviado = true;

        }

        

        private Attachment generarReporte()
        {
            //string file = System.IO.Path.GetFileName("C:\\Users\\Soporte\\Desktop\\19.02.2017.0.20.pdf");
            string file = "C:\\Users\\Soporte\\Desktop\\19.02.2017.0.20.pdf";
            return new Attachment(file);
        }

    }
}
