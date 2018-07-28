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
            List<Cita> listaCitaDatos = cit.ListarCitaDatos();
            var lista = listaCitaDatos.Select(x => new { x.FechaIngreso });
            var vplaca = listaCitaDatos.Select(x => new { x.Placa });
            var vista = listaCita.Select(x => new { x.Estado, x.Cedula, x.FechaIngreso, x.KM, x.Marca, x.Placa }).ToList();
            Ggvcitas.DataSource = vista;
            Ggvcitas.DataBind();
            Drpfecha.DataSource = lista;
            Drpfecha.DataBind();
            Drpplaca.DataSource = vplaca;
            Drpplaca.DataBind();
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
           // Actualizar();
        }
        //private void Actualizar()
        //{
        //    try
        //    {
        //        Cliente cliente = new Cliente
        //        {
        //            Cedula = "Llegado"
        //        };
        //        cli.ActualizarCliente(cliente);
        //        MostarMensaje("Auto ingreso con exito");
        //    }
        //    catch (Exception)
        //    {
        //        MostarMensajeError("No se actualiza estado de la cita");
        //    }
        //}
    }
}