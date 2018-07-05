using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using TallerH.DATA;

namespace Taller_Hernandez
{
    public partial class Cotizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtDestinatario.Text.Trim() == ""))
                {
                    Correo obj_correo = new Correo();
                    obj_correo.Destinatario = new List<string>();
                    obj_correo.Asunto = txtAsunto.Text;
                    obj_correo.Cuerpo = txtCuerpo.Text;

                    string correos = txtDestinatario.Text;
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
                            SmtpServer.Credentials = new System.Net.NetworkCredential("carlosms_94@hotmail.es", "moralesMS23");
                            SmtpServer.EnableSsl = true;
                            SmtpServer.Send(mail);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    }
