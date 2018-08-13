using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using TallerH.DATA;
using System.Data.SqlClient;

namespace Taller_Hernandez
{
    public partial class Cotizar : System.Web.UI.Page
    {
        public string Vcorreo;
        public string Vpass;
        public SqlConnection cn = new SqlConnection(@"Data Source=HP\SQLEXPRESS23;Initial Catalog=TallerHernandez;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand co = new SqlCommand("Select Correo from Configcorreo;", cn);
            cn.Open();
            SqlDataReader dr = co.ExecuteReader();
            while (dr.Read() == true)
            {
                Vcorreo=dr[0].ToString();
            }
            cn.Close();

            SqlCommand cm = new SqlCommand("Select Pass from Configcorreo;", cn);
            cn.Open();
            SqlDataReader drp = cm.ExecuteReader();
            while (drp.Read() == true)
            {
                var Vpass1 = drp[0].ToString();
               // Vpass = UI.Encriptacion.Decriptar(Vpass1);
            }
            cn.Close();

            //SqlCommand Vcorreo = new SqlCommand("Select Correo from Configcorreo;", cn);
            //SqlCommand Vpass = new SqlCommand("Select Pass from Configcorreo;", cn);

            //MostarMensajeError(Vcorreo);
            //cn.Open();
            //SqlDataReader da = ca.ExecuteReader();
            //while (da.Read() == true)
            //{
            //    Vcorreo = ;
            //    Vpass =;
            //}
            //cn.Close();
        }
        private void MostarMensajeError(string texto)
        {
            mensajeError.Visible = true;
            textoMensajeError.InnerHtml = texto;
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
                        mail.From = new MailAddress(Vcorreo);

                        mail.Subject = obj_correo.Asunto;
                        mail.Body = obj_correo.Cuerpo;
                        mail.To.Add(new MailAddress(item));
                        SmtpServer.Port = 25;

                        using (SmtpServer)
                        {
                            SmtpServer.Credentials = new System.Net.NetworkCredential(Vcorreo, Vpass);
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
