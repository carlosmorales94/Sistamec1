using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TallerH.BLL.Interfaces;
using TallerH.BLL.Metodos;
using TallerH.DATA; 

namespace Taller_Hernandez
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                      
            
        }

        protected void btnOlvidoPass_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("OlvidarContrasena.aspx", false);
            }
            catch (Exception)
            {

            }
        }
        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            
            try
            {
                IUsuario usu = new MUsuario();
                var usuario = usu.BuscarUsuario( txtUsuario .Text, UI.Encriptacion.Encriptar(txtContra .Text));
                if (usuario != null)
                {
                    Response.Redirect("Ingreso_Vehiculo.aspx", false);
                }
                else
                {
                    mensaje.Visible = false;
                    textoMensaje.InnerHtml = string.Empty;
                    mensajeError.Visible = true;
                    textoMensajeError.InnerHtml = "Usuario O Contraseña incorrecto";
                    txtContra.Text = string.Empty;
                    txtUsuario.Text = string.Empty;
                    txtUsuario.Focus();

                }
            }
            catch (Exception)
            {
              
            }
            }
}
}