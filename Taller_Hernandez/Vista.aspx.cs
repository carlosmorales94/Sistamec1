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
    public partial class Vista : System.Web.UI.Page
    {

        public SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-JNT2CUC4;Initial Catalog=TallerHernandez;Integrated Security=True");
        ICita cit = new MCita();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //List<Cita> listaCita = cit.ListarCita();
            //List<Cita> listaCitaDatos = cit.ListarCitaDatos();
            //var lista = listaCitaDatos.Select(x => new { x.FechaIngreso });
            //var vplaca = listaCitaDatos.Select(x => new { x.Placa });
            //var vista = listaCita.Select(x => new { x.Estado, x.Cedula, x.FechaIngreso, x.KM, x.Marca, x.Placa }).ToList();
            //Ggvcitas.DataSource = vista;
            //Ggvcitas.DataBind();
            //Drpfecha.DataSource = lista;
            //Drpfecha.DataBind();
            //Drpplaca.DataSource = vplaca;
            //Drpplaca.DataBind();
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
            /* try
             {

                 var vista = cit.BuscarCita(Clcita.SelectedDate); /*cli.BuscarCliente(Convert.ToInt32(TxtBuscarCedula.Text));
                 if (Clcita.SelectedDate != null)
                 {
                     Ggvcitas.DataSource = vista;
                     Ggvcitas.DataBind();
                 }
                 else
                 {
                     MostarMensajeError("El Cliente no existe");
                 }
             }
             catch (Exception)
             {
                 MostarMensajeError("Ocurrio un error");
             }*/

            SqlDataAdapter da = new SqlDataAdapter("Mostrar", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@fechaIngreso", SqlDbType.DateTime).Value = Clcita.SelectedDate;
           
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.Ggvcitas.DataSource = dt;
        }
        protected void Btnllegado_Click(object sender, EventArgs e)
        {
           // Actualizar();
        }

        protected void Clcita_SelectionChanged(object sender, EventArgs e)
        {

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