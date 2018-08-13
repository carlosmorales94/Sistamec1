using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TallerH.BLL.Interfaces;
using TallerH.BLL.Metodos;
using TallerH.DATA;

namespace Taller_Hernandez
{
    public partial class ConfCorreo : System.Web.UI.Page
    {
        MConfigcorreo procesar = new MConfigcorreo();
        
        TallerH.DATA.Configcorreo config;

        public SqlConnection cn = new SqlConnection(@"Data Source=HP\SQLEXPRESS23;Initial Catalog=TallerHernandez;Integrated Security=True");
        IConfigcorreo corr = new MConfigcorreo();
        protected void Page_Load(object sender, EventArgs e)
        {
            IConfigcorreo van = new MConfigcorreo();
            List<Configcorreo> listarCorreo = van.ListarCorreo();
            var vcordis = listarCorreo.Select(x => new { x.Correo });
            Gbcorreo.DataSource = vcordis;
            Gbcorreo.DataBind();
        }

        private void GetValues()
        {
            config = new TallerH.DATA.Configcorreo
            {
                Correo = TxtCorreo.Text,
                Pass = UI.Encriptacion.Encriptar(Txtcontra.Text),
              
            };
            }

        protected void Btnaceptar_Click(object sender, EventArgs e)
        {

            try
            {
                GetValues();
                procesar.Actualizar(config);
                Txtcontra.Text = "";
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        private void Actualizar()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_Act_Configcorreo", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Correo", SqlDbType.Char).Value = TxtCorreo.Text;
            da.SelectCommand.Parameters.Add("@Pass", SqlDbType.Char).Value = Txtcontra.Text;

        }

        private void limpiar()
        {
            Txtcontra.Text = "";
            TxtCorreo.Text = "";
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