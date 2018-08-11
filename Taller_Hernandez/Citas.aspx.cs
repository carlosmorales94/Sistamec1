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
        IAno vano = new MAno();
        IEstilos vest = new MEstilos();
        IMarca vmar = new MMarca();

        public string cedic;
        public string correoic;

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Ano> listaAno = vano.ListarAno();
            var listaA = listaAno.Select(x => new { x.Descripano });
            Drpano.DataSource = listaA;
            Drpano.DataBind();
            List<Estilos> listaEstilo = vest.ListarEstilo();
            var listaE = listaEstilo.Select(x => new { x.Descripestilo });
            DrpEstilo.DataSource = listaE;
            DrpEstilo.DataBind();
            List<Marca> listaMarca = vmar.ListarMarca();
            var listaM = listaMarca.Select(x => new { x.Descripmarca });
            DrpMarca.DataSource = listaM;
            DrpMarca.DataBind();

            if (Request.Params["parametroced"] != null | Request.Params["parametroced"] != null)
            {
                cedic = Request.Params["parametroced"];
                correoic = Request.Params["parametrocorreo"];
            }
        }
    }
}

      /*  protected void BtnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                Cita citas = new Cita
                {
                    ProVeh = TxtPro.Text,
                    Placa = TxtPlaca.Text,
                    FechaIngreso = Calendar1.SelectedDate,
                    Cedula = 1,
                    Estado = "Pendiente",
                    Marca = DrpMarca.Text,
                    Estilo = "4x4",//DrpEstilo.Text,
                    Ano = 15/08/18, //Convert.ToInt32(Drpano.Text),
                    Nota = "Nada",
                    Bin = Convert.ToInt32(TxtBin.Text),
                    KM = Convert.ToInt32(TxtKM.Text),
                    RevisionIntervalos = "RV",
                    MantenimientoPrevio = "MP",
                    DanosVehiculo = "DV",
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
            //try
            //{
            //    if (!(correoic == ""))
            //    {
            //        Correo obj_correo = new Correo();
            //        obj_correo.Destinatario = new List<string>();
            //        obj_correo.Asunto = "Confirmacion de su cita en Taller Hernandez";
            //        obj_correo.Cuerpo = "Departe de Taller Hernandez le confirmamos su cita a Nombre de: " +
            //        " para su vehiculo Marca: " + ", el cual presenta los problemas de: " + TxtPro.Text + ", para la fecha del: " + Calendar1.SelectedDate +
            //        ", en caso de alguna cancelacion o inconveniente favor comunicarse al 2203-2180";
            //        string correos = correoic;
            //        string[] correo_individual = correos.Split(';');
            //        foreach (string words in correo_individual)
            //        {
            //            obj_correo.Destinatario.Add(words);
            //        }

            //        foreach (var item in obj_correo.Destinatario)
            //        {
            //            MailMessage mail = new MailMessage();
            //            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            //            mail.From = new MailAddress("carlosms_94@hotmail.es");
            //            mail.Subject = obj_correo.Asunto;
            //            mail.Body = obj_correo.Cuerpo;
            //            mail.To.Add(new MailAddress(item));
            //            SmtpServer.Port = 25;
            //            using (SmtpServer)
            //            {
            //                SmtpServer.Credentials = new System.Net.NetworkCredential("carlosms_94@hotmail.es", "moralesMS23");
            //                SmtpServer.EnableSsl = true;
            //                SmtpServer.Send(mail);
            //            }
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    MostarMensajeError("Ocurrio un error");
            //}
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
}*/