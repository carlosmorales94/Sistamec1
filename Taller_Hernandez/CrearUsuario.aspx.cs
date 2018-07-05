using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TallerH.DATA;
using TallerH.BLL.Interfaces;
using TallerH.BLL.Metodos;
using System.IO;

namespace Taller_Hernandez
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        int fact;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                IUsuario usu = new MUsuario();
                var nombreUsuario = usu.BuscarUsuario(TxtUsuarioIns.Text, UI.Encriptacion.Encriptar(TxtcontraseñaIns.Text));
                if (TxtcontraseñaIns.Text != Txtconfirmar.Text)
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textoMensajeError.InnerHtml = "Contraseñas no coinsiden!";

                }
                else if (nombreUsuario != null)
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textoMensajeError.InnerHtml = "Usuario ya existe, intente otra vez";

                }
                if (rdfactura.Checked == true)
                {
                    fact = 1;                                   
                }

                else
                {
                    var usuario = new TallerH.DATA.Usuario
                    {
                        Username = TxtUsuarioIns.Text,
                        Password = UI.Encriptacion.Encriptar(TxtcontraseñaIns.Text),
                        //Factura = fact,
                        //Factura = Convert.ToInt32(rdfactura.Text),
                        //Inventario = Convert.ToInt32(rdinventario.Text),
                        //Citas = Convert.ToInt32(rdcitas.Text),
                        //Configuracion = Convert.ToInt32(rdconfiguracion.Text),
                        //Reportes = Convert.ToInt32(rdreportes.Text)
                    };
                    usu.InsertarUsuario(usuario);
                    mensaje.Visible = true;
                    mensajeError.Visible = true;
                    MostarMensaje("Usuario Insertado exitosamente!");
                    Response.Redirect("Login.aspx?creado-true", false);
                }


            }
            catch (Exception ex)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                MostarMensajeError("Ocurrio un error "+ex.Message);
            }
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