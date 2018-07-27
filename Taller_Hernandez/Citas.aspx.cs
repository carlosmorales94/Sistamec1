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
    public partial class Citas : System.Web.UI.Page
    {
        public string cedic;
        public string correoic;

        protected void Page_Load(object sender, EventArgs e)
        {
            DrpMarca.Items.Add("Acura");
            DrpMarca.Items.Add("Alfa Romeo");
            DrpMarca.Items.Add("AMC");
            DrpMarca.Items.Add("Aro");
            DrpMarca.Items.Add("Asia");
            DrpMarca.Items.Add("Aston Martin");
            DrpMarca.Items.Add("Audi");
            DrpMarca.Items.Add("Avanti");
            DrpMarca.Items.Add("Bentley");
            DrpMarca.Items.Add("BMW");
            DrpMarca.Items.Add("Buick");
            DrpMarca.Items.Add("BYD");
            DrpMarca.Items.Add("Cadillac");
            DrpMarca.Items.Add("Chana");
            DrpMarca.Items.Add("Changan");
            DrpMarca.Items.Add("Chery");
            DrpMarca.Items.Add("Chevrolet");
            DrpMarca.Items.Add("Chysley");
            DrpMarca.Items.Add("Citroen");
            DrpMarca.Items.Add("Dacia");
            DrpMarca.Items.Add("Daewoo");
            DrpMarca.Items.Add("Daihatsu");
            DrpMarca.Items.Add("Datsun");
            DrpMarca.Items.Add("Dodge/RAM");
            DrpMarca.Items.Add("Eagle");
            DrpMarca.Items.Add("Faw");
            DrpMarca.Items.Add("Ferrari");
            DrpMarca.Items.Add("Fiat");
            DrpMarca.Items.Add("Ford");
            DrpMarca.Items.Add("Foton");
            DrpMarca.Items.Add("Freightliner");
            DrpMarca.Items.Add("Geely");
            DrpMarca.Items.Add("Geo");
            DrpMarca.Items.Add("GMC");
            DrpMarca.Items.Add("Gonow");
            DrpMarca.Items.Add("Great Wall");
            DrpMarca.Items.Add("Hafei");
            DrpMarca.Items.Add("Heibao");
            DrpMarca.Items.Add("Higer");
            DrpMarca.Items.Add("Hino");
            DrpMarca.Items.Add("Honda");
            DrpMarca.Items.Add("Hummer");
            DrpMarca.Items.Add("Hyundai");
            DrpMarca.Items.Add("infinity");
            DrpMarca.Items.Add("International");
            DrpMarca.Items.Add("Isuzu");
            DrpMarca.Items.Add("Iveco");
            DrpMarca.Items.Add("JAC");
            DrpMarca.Items.Add("Jaguar");
            DrpMarca.Items.Add("Jeep");
            DrpMarca.Items.Add("Jinbei");
            DrpMarca.Items.Add("JMC");
            DrpMarca.Items.Add("Kenworth");
            DrpMarca.Items.Add("Kia");
            DrpMarca.Items.Add("Lada");
            DrpMarca.Items.Add("Lamborghini");
            DrpMarca.Items.Add("Lancia");
            DrpMarca.Items.Add("Land Rover");
            DrpMarca.Items.Add("Lexus");
            DrpMarca.Items.Add("Lifan");
            DrpMarca.Items.Add("Lincoln");
            DrpMarca.Items.Add("Lotus");
            DrpMarca.Items.Add("Mack");
            DrpMarca.Items.Add("Magiruz");
            DrpMarca.Items.Add("Mahindra");
            DrpMarca.Items.Add("Maserati");
            DrpMarca.Items.Add("Mazda");
            DrpMarca.Items.Add("Marcedez Benz");
            DrpMarca.Items.Add("Mercury");
            DrpMarca.Items.Add("MG");
            DrpMarca.Items.Add("Mini");
            DrpMarca.Items.Add("Mitsubishi");
            DrpMarca.Items.Add("NIssan");
            DrpMarca.Items.Add("Oldsmobile");
            DrpMarca.Items.Add("Opel");
            DrpMarca.Items.Add("Peternilt");
            DrpMarca.Items.Add("Peugeot");
            DrpMarca.Items.Add("Plymounth");
            DrpMarca.Items.Add("Polarsun");
            DrpMarca.Items.Add("Pontiac");
            DrpMarca.Items.Add("Porshe");
            DrpMarca.Items.Add("Proton");
            DrpMarca.Items.Add("Rambier");
            DrpMarca.Items.Add("Ranault");
            DrpMarca.Items.Add("Reva");
            DrpMarca.Items.Add("Rolls Royce");
            DrpMarca.Items.Add("Rover");
            DrpMarca.Items.Add("Saab");
            DrpMarca.Items.Add("Samsung");
            DrpMarca.Items.Add("Saturn");
            DrpMarca.Items.Add("Scania");
            DrpMarca.Items.Add("Scion");
            DrpMarca.Items.Add("Seat");
            DrpMarca.Items.Add("Skoda");
            DrpMarca.Items.Add("Smart");
            DrpMarca.Items.Add("Ssang Yong");
            DrpMarca.Items.Add("Subaru");
            DrpMarca.Items.Add("Suzuki");
            DrpMarca.Items.Add("Tianma");
            DrpMarca.Items.Add("Tiger Truck");
            DrpMarca.Items.Add("Toyota");
            DrpMarca.Items.Add("Volkswagen");
            DrpMarca.Items.Add("Volvo");
            DrpMarca.Items.Add("Western Star");
            DrpMarca.Items.Add("Yugo");

            if (Request.Params["parametroced"] != null | Request.Params["parametroced"] != null)
            {
                cedic = Request.Params["parametroced"];
                correoic = Request.Params["parametrocorreo"];
            }
        }

        protected void BtnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                Cita citas = new Cita
                {
                    //NombreCliente = TxtNombre.Text,
                    //Movil = Convert.ToInt32(txMovil.Text),
                    //Correo = TxtNombre.Text,
                    // Marca = TxtMarca.Text,
                    ProVeh = TxtPro.Text,
                    Placa = TxtPlaca.Text,
                    FechaIngreso = Convert.ToString( Calendar1.SelectedDate),
                    Cedula = cedic,
                };
                ICita cit = new MCita();
                cit.InsertarCita(citas);
                MostarMensaje("Cita completada con exito!");
                Limpiar();
            }
            catch (Exception)
            {
                MostarMensajeError("No se agendo la cita");
            }
            try
            {
                if (!(correoic == ""))
                {
                    Correo obj_correo = new Correo();
                    obj_correo.Destinatario = new List<string>();
                    obj_correo.Asunto = "Confirmacion de su cita en Taller Hernandez";
                    obj_correo.Cuerpo = "Departe de Taller Hernandez le confirmamos su cita a Nombre de: " +
                    " para su vehiculo Marca: " +  ", el cual presenta los problemas de: " + TxtPro.Text + ", para la fecha del: " + Calendar1.SelectedDate +
                    ", en caso de alguna cancelacion o inconveniente favor comunicarse al 2203-2180";
                    string correos = correoic;
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
                MostarMensajeError("Ocurrio un error");
            }
        }
        private void Limpiar()
        {
            //TxtCorreo.Text = "";
            //TxtNombre.Text = "";
            //txMovil.Text = "";
            TxtPlaca.Text = "";
            TxtPro.Text = "";
        }
        private void MostarMensaje(string texto)
        {
            mensaje.Visible = true;
            mensajeError.Visible = false;
            textoMensajeError.InnerHtml = string.Empty;
            textoMensaje.InnerHtml = texto;
        }

        private void MostarMensajeError(string texto)
        {
            mensaje.Visible = false;
            mensajeError.Visible = true;
            textoMensajeError.InnerHtml = texto;
            textoMensaje.InnerHtml = string.Empty;
        }
    }
}