using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.IO;
using TallerH.BLL.Interfaces;
using TallerH.BLL.Metodos;
using TallerH.DATA;

namespace Taller_Hernandez
{
    public partial class OlvidarContrasena : System.Web.UI.Page
    {
        int n1, n2, n3, n4;
        char l1, l2, l3, l4;
        string pass;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnolvidarpass_Click(object sender, EventArgs e)
        {

            try
            {
                Random alea = new Random();
                n1 = alea.Next(97, 123);
                n2 = alea.Next(65, 91);
                n3 = alea.Next(48, 58);
                n4 = alea.Next(97, 123);
                l1 = Convert.ToChar(n1);
                l2 = Convert.ToChar(n2);
                l3 = Convert.ToChar(n3);
                l4 = Convert.ToChar(n4);
                pass = string.Concat(l1,l2,l3,l4);
                //IUsuario usu = new MUsuario();
                //var usuario = usu.BuscarUsuario(txtUsuario.Text, UI.Encriptacion.Encriptar(txtContra.Text));
                //if (usuario != null)
                //{
                //    Response.Redirect("Ingreso_Vehiculo.aspx", false);
                //}
            }
            catch (Exception)
            {

            }

            try
            {
                if (!(Txtemail.Text.Trim() == ""))
                {
                    Correo obj_correo = new Correo();
                    obj_correo.Destinatario = new List<string>();
                    obj_correo.Asunto = "Cambio de Contraseña, Taller Hernandez";
                    obj_correo.Cuerpo = "Su nuevo Password :" +pass;
                    string correos = Txtemail.Text;
                    string[] correo_individual = correos.Split(';');
                    foreach (string words in correo_individual)
                    {
                        obj_correo.Destinatario.Add(words);
                    }

                    foreach (var item in obj_correo.Destinatario)
                    {
                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
                        mail.From = new MailAddress("carlosms_94@hotmail.es");
                        mail.Subject = obj_correo.Asunto;
                        mail.Body = obj_correo.Cuerpo;
                        mail.To.Add(new MailAddress(item));
                        SmtpServer.Port = 25;
                        using (SmtpServer)
                        {
                            SmtpServer.Credentials = new System.Net.NetworkCredential("carlosms_94@hotmail.es", "Morales20.");
                            SmtpServer.EnableSsl = true;
                            SmtpServer.Send(mail);
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            Response.Redirect("CambioContrasena.aspx", false);
        }
    }
}