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
    public partial class Ingreso_Vehiculo : System.Web.UI.Page
    {
        ICita cit = new MCita();
        ICliente cli = new MCliente();
        IAuto aut = new MAuto();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngreVeh_Click(object sender, EventArgs e)
        {

            try
            {
                Auto auto = new Auto
                {
                    Placa = TxtPlaca.Text,
                    Marca = TxtMarca.Text,
                    Estilo = TxtEstilo.Text,
                    Ano = Convert.ToInt32(TxtAno.Text),
                    Nota = TxtNota.Text,
                    Bin = Convert.ToInt32(TxtBin.Text),
                    KM = Convert.ToInt32(TxtKM.Text),
                    ProblemasVehiculo = TxtProVeh.Text,
                    RevisionIntervalos = TxtRevInt.Text,
                    MantenimientoPrevio = TxtManPrev.Text,
                    DanosVehiculo = TxtDanVeh.Text
                };
                IAuto aut = new MAuto();
                aut.InsertarAuto(auto);
            }
            catch (Exception ex)
            {
                MostarMensajeError("Ocurrio un error, existen campos en blanco" +ex.Message);
                Limpiar();
            }
            try
            {
                Cliente cliente = new Cliente
                {
                    Placa = TxtPlaca.Text,
                    NombreCliente = TxtNCliente.Text,
                    Telefono = Convert.ToInt32(TxtTelefono.Text),
                    Movil = Convert.ToInt32(TxtMovil.Text),
                    Correo = TxtCorreo.Text,
                    Cedula= Convert.ToInt32(TxtCedula.Text)
                };
                cli.InsertarCliente(cliente);
                MostarMensaje("Vehiculo se registro con exito");
                Limpiar();
            }

            catch(Exception)
            {
                MostarMensajeError("Ocurrio un error, existen campos en blanco");
                //throw;
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
            TxtMarca.Text = "";
            TxtEstilo.Text = "";
            TxtAno.Text = "";
            TxtBin.Text = "";
            TxtPlaca.Text = "";
            TxtKM.Text = "";
            TxtNota.Text = "";
            TxtProVeh.Text = "";
            TxtRevInt.Text = "";
            TxtManPrev.Text = "";
            TxtDanVeh.Text = "";
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {

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

        protected void Btn_Click(object sender, EventArgs e)
        {

        }

        protected void BtnBuscarAuto_Click(object sender, EventArgs e)
        {
            try
            {

                var cliente = cli.BuscarCliente(TxtBusplaIngVeh.Text);
                var auto = aut.BuscarAuto(TxtBusplaIngVeh.Text);
                if (auto != null )
                {
                    TxtCedula.Text = cliente.Cedula.ToString();
                    TxtProVeh.Text = auto.ProblemasVehiculo;
                    TxtPlaca.Text = auto.Placa;
                    TxtEstilo.Text = auto.Estilo;
                    TxtMarca.Text = auto.Marca;
                    TxtAno.Text = auto.Ano.ToString();
                    TxtNota.Text = auto.Nota;
                    TxtBin.Text = auto.Bin.ToString();
                    TxtKM.Text = auto.KM.ToString();
                    TxtRevInt.Text = auto.RevisionIntervalos;
                    TxtManPrev.Text = auto.MantenimientoPrevio;
                    TxtDanVeh.Text = auto.DanosVehiculo;
                    TxtNCliente.Text = cliente.NombreCliente;
                    TxtTelefono.Text = cliente.Telefono.ToString();
                    TxtMovil.Text = cliente.Movil.ToString();
                    TxtCorreo.Text = cliente.Correo;
                    TxtPlaca.Text = cliente.Placa;
                }
                else
                {
                    MostarMensajeError("El auto no existe");
                }
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }
        }
        
        protected void BtnAct_Click(object sender, EventArgs e)
        {
            try
            {               
                Cliente cliente = new Cliente
                {
                    Cedula= Convert.ToInt32( TxtCedula.Text),
                    NombreCliente = TxtNCliente.Text,
                    Telefono = Convert.ToInt32( TxtTelefono.Text),
                    Movil = Convert.ToInt32(TxtMovil.Text),
                    Correo= TxtCorreo.Text,
                    Placa=TxtPlaca.Text
                };
            cli.ActualizarCliente(cliente);
            MostarMensaje("Se actualizaron los datos");
                Limpiar();
            }
            catch(Exception)
            {
                MostarMensajeError("Ocurrio un error");
                Limpiar();
            }
            try
            {
                Auto auto = new Auto
                {
                    Placa = TxtPlaca.Text,
                    Marca = TxtMarca.Text,
                    Estilo = TxtMarca.Text,
                    Ano = Convert.ToInt32(TxtAno.Text),
                    Nota = TxtNota.Text,
                    Bin = Convert.ToInt32(TxtBin.Text),
                    KM = Convert.ToInt32(TxtKM.Text),
                    ProblemasVehiculo = TxtProVeh.Text,
                    RevisionIntervalos = TxtRevInt.Text,
                    MantenimientoPrevio = TxtManPrev.Text,
                    DanosVehiculo = TxtDanVeh.Text                
            };
                aut.ActualizarAuto(auto);
                MostarMensaje("Se actualizaron los datos");
                Limpiar();
            }
            catch(Exception)
            {
                MostarMensajeError("Ocurrio un error");
                Limpiar();
            }
   }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                aut.EliminarAuto(TxtBusplaIngVeh.Text);
                cli.EliminarCliente(TxtBusplaIngVeh.Text);
                MostarMensaje("Auto Eliminado");
                Limpiar();
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
                Limpiar();
            }
           
        }

        protected void BtCita_Click(object sender, EventArgs e)
        {
            try
            {
                var cita = cit.BuscarCita(TxtBusplaIngVeh.Text);              
                if (cita != null)
                {
                    TxtNCliente.Text = cita.NombreCliente;
                    TxtMovil.Text = cita.Movil.ToString();
                    TxtCorreo.Text = cita.Correo.ToString();
                    TxtMarca.Text = cita.Marca;
                    TxtProVeh.Text = cita.ProVeh;
                    TxtPlaca.Text = cita.Placa.ToString();
                }
                else
                {
                    MostarMensajeError("El auto no tiene una citas agendadas!");
                }
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }    

                try
                {
                    cit.EliminarCita(TxtBusplaIngVeh.Text);
                }
                catch (Exception)
                {
                    MostarMensajeError("Ocurrio un error");
                }
            }
            }
}





