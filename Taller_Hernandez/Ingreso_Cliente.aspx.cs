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
    public partial class Ingreso_Cliente : System.Web.UI.Page
    {
        ICliente cli = new MCliente();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCliente_Click(object sender, EventArgs e)
        {
            InsertarCliente();
        }
        public void InsertarCliente()
        {
            try
            {
                Cliente cliente = new Cliente
                {
                    NombreCliente = TxtNCliente.Text,
                    ApellidoCliente = TxtApellido.Text,
                    Telefono = Convert.ToInt32(TxtTelefono.Text),
                    Movil = Convert.ToInt32(TxtMovil.Text),
                    Correo = TxtCorreo.Text,
                    Nota = TxtNota.Text,
                    Cedula = Convert.ToInt32(TxtCedula.Text)
                };
                cli.InsertarCliente(cliente);
                MostarMensaje("Cliente se registro con exito");
                Limpiar();
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error, existen campos en blanco en Cliente");
            }
        }
        private void Limpiar()
        {
            TxtNCliente.Text = "";
            TxtCedula.Text = "";
            TxtMovil.Text = "";
            TxtNota.Text = "";
            TxtTelefono.Text = "";
            TxtCorreo.Text = "";
            TxtApellido.Text = "";
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

        protected void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = cli.BuscarCliente(Convert.ToInt32(TxtBuscarCedula.Text));
                if (TxtBuscarCedula != null)
                {
                    TxtCedula.Text = cliente.Cedula.ToString();
                    TxtNCliente.Text = cliente.NombreCliente;
                    TxtTelefono.Text = cliente.Telefono.ToString();
                    TxtMovil.Text = cliente.Movil.ToString();
                    TxtCorreo.Text = cliente.Correo;
                    TxtApellido.Text = cliente.ApellidoCliente;
                    TxtNota.Text = cliente.Nota.ToString();
                }
                else
                {
                    MostarMensajeError("El Cliente no existe");
                }
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }
        }

        protected void BtnAct_Click(object sender, EventArgs e)
        {
            Actualizar();
            Response.Redirect("citas.aspx?parametro=" + Convert.ToInt32(TxtCedula.Text) + TxtCorreo.Text);

        }
        protected void BtnAgendar_Click(object sender, EventArgs e)
        {
            InsertarCliente();
            Response.Redirect("citas.aspx?parametro=" + Convert.ToInt32(TxtCedula.Text)+ TxtCorreo.Text );
        }

        private void Actualizar()
        {
            try
            {
                Cliente cliente = new Cliente
                {
                    Cedula = Convert.ToInt32(TxtCedula.Text),
                    NombreCliente = TxtNCliente.Text,
                    ApellidoCliente = TxtApellido.Text,
                    Telefono = Convert.ToInt32(TxtTelefono.Text),
                    Movil = Convert.ToInt32(TxtMovil.Text),
                    Correo = TxtCorreo.Text,
                    Nota = TxtNota.Text,
                };
                cli.ActualizarCliente(cliente);
                MostarMensaje("Se actualizaron los datos del cliente con exito");
                Limpiar();
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
                Limpiar();
            }
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cli.EliminarCliente(Convert.ToInt32(TxtBuscarCedula.Text));
                MostarMensaje("Cliente Eliminado");
                Limpiar();
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
                Limpiar();
            }

        }

        protected void TxtCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





