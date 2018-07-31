using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TallerH.BLL.Interfaces;
using TallerH.BLL.Metodos;
using TallerH.DATA;
using System.IO;

namespace Taller_Hernandez
{
    public partial class ConfCorreo : System.Web.UI.Page
    {
        IConfigcorreo corr = new MConfigcorreo();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnaceptar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            try
            {
                Configcorreo configcorreo = new Configcorreo
                {
                    Correo = TxtCorreo.Text,
                    Pass = Txtcontra.Text
                };
                corr.ActualizarCorreo(configcorreo);
                MostarMensaje("Se actualizaron los datos exitosamente");
                limpiar();
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
                limpiar();
            }
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