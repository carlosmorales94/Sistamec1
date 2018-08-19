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
using System.Data.SqlClient;

namespace Taller_Hernandez
{
    public partial class Citas : System.Web.UI.Page
    {
        public SqlConnection cn = new SqlConnection(@"Data Source=HP\SQLEXPRESS23;Initial Catalog=TallerHernandez;Integrated Security=True");
        IAno vano = new MAno();
        IEstilos vest = new MEstilos();
        IMarca vmar = new MMarca();
        public string contpar ;
        public string cedic;
        public string correoic;

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand ca = new SqlCommand("Select Descripano from Ano;", cn);
            cn.Open();
            SqlDataReader da = ca.ExecuteReader();
            while (da.Read() == true)
            {
                Drpano.Items.Add(da[0].ToString());
            }
            cn.Close();

            SqlCommand cm = new SqlCommand("Select Descripmarca from Marca;", cn);
            cn.Open();
            SqlDataReader dm = cm.ExecuteReader();
            while (dm.Read() == true)
            {
                DrpMarca.Items.Add(dm[0].ToString());
            }
            cn.Close();

            SqlCommand ce = new SqlCommand("Select Descripestilo from Estilos;", cn);
            cn.Open();
            SqlDataReader de = ce.ExecuteReader();
            while (de.Read() == true)
            {
                DrpEstilo.Items.Add(de[0].ToString());
            }
            cn.Close();

            //List<Ano> listaAno = vano.ListarAno();
            //var listaA = listaAno.Select(x => new { x.Descripano });
            //Drpano.DataSource = listaA;
            //Drpano.DataBind();
            //List<Estilos> listaEstilo = vest.ListarEstilo();
            //var listaE = listaEstilo.Select(x => new { x.Descripestilo });
            //DrpEstilo.DataSource = listaE;
            //DrpEstilo.DataBind();
            //List<Marca> listaMarca = vmar.ListarMarca();
            //var listaM = listaMarca.Select(x => new { x.Descripmarca });
            //DrpMarca.DataSource = listaM;
            //DrpMarca.DataBind();

            //  if (Request.Params["ced"] != null | Request.Params["correo"] != null)
            if (Request.Params["parametro"] != null )
            {
                contpar = Request.Params["parametro"].PadRight(100,' ');
                cedic = contpar.Substring(0,9);
                correoic = contpar.Substring(9,90);
            }
        }



        protected void BtnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                Cita citas = new Cita
                {
                    ProVeh = TxtPro.Text,
                    Placa = TxtPlaca.Text,
                    FechaIngreso = Calendar1.SelectedDate.ToString(),
                    Cedula = Convert.ToInt32(cedic),
                    Estado = "Pendiente",
                    Descripmarca = DrpMarca.Text,
                    Descripestilo = DrpEstilo.Text,
                    Descripano = Convert.ToInt32(Drpano.Text),
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
                enviocorreo();
            }
            catch (Exception)
            {
                MostarMensajeError("No se agendo la cita");
            }
        }
        private void enviocorreo()
        {
            try
            {
                if (!(correoic == ""))
                {
                    Correo obj_correo = new Correo();
                    obj_correo.Destinatario = new List<string>();
                    obj_correo.Asunto = "Confirmacion de su cita en Taller Hernandez";
                    obj_correo.Cuerpo = "Departe de Taller Hernandez le confirmamos su cita a Nombre de: " +
                    " para su vehiculo Marca: " + ", el cual presenta los problemas de: " + TxtPro.Text + ", para la fecha del: " + Calendar1.SelectedDate +
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
                            SmtpServer.Credentials = new System.Net.NetworkCredential("carlosms_94@hotmail.es", "Pass");
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
        //private void Limpiar()
        //{
        //    //TxtCorreo.Text = "";
        //    //TxtNombre.Text = "";
        //    //txMovil.Text = "";
        //    TxtPlaca.Text = "";
        //    TxtPro.Text = "";
        //}
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

