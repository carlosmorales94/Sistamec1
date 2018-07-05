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
    public partial class Vista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ICita cit = new MCita();
            List<Cita> listaCita = cit.ListarCita();
            var lista = listaCita.Select(x => new { x.FechaIngreso });
            //ClFechas.DataSource = lista;
            //ClFechas.DataBind();
            try
            {
                if (!Page.IsPostBack)
                {
                    lvProductos.DataSource = cit.ListarCita();
                    lvProductos.DataBind();
                }
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
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

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}