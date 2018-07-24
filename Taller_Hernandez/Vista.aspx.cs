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
        ICita cit = new MCita();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Cita> listaCita = cit.ListarCita();
            var vista = listaCita.Select(x => new {x.Estado, x.Cedula, x.FechaIngreso, x.KM, x.Marca,x.Placa }).ToList();
            Ggvcitas.DataSource = vista;
            Ggvcitas.DataBind();
            var lista = listaCita.Select(x=>new {x.FechaIngreso}).ToList();
            Drpfecha.DataSource = lista;
            Drpfecha.DataBind();            
            try
            {
                if (!Page.IsPostBack)
                {

                    //lvProductos.DataSource = cit.ListarCita();
                   // lvProductos.DataBind();
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
        protected void Btnllegado_Click(object sender, EventArgs e)
        {
            try
            {
                Cita cita = new Cita
                {
                    Estado="Llegado",
                };
                cit.ActualizarCita(cita);
                MostarMensaje("ChekIn Exitos");
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }
        }
        
    }
}