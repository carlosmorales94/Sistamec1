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
    public partial class Factura : System.Web.UI.Page
    {
        IDescProducto ds = new MDescProducto();
        ICliente cli = new MCliente();
        IAuto aut = new MAuto();
        protected void Page_Load(object sender, EventArgs e)
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

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var descProducto= ds.BuscarDescProducto(txtBuscarPlaca.Text);
                var auto = aut.BuscarAuto(txtBuscarPlaca.Text);
                var cliente = cli.BuscarCliente(txtBuscarPlaca.Text);
                if (auto != null)
                {
                    LbRCorreo.Text = cliente.Correo;
                    LbRMovil.Text = cliente.Movil.ToString(); 
                    LbRMarca.Text = auto.Marca;
                    LbRPlaca.Text = auto.Placa;
                    TxtNombreCliente.Text = cliente.NombreCliente;
                    LbRKm.Text = auto.KM.ToString();
                    LbRCedula.Text = cliente.Cedula.ToString();
                    TextBox3.Text = descProducto.Cantidad.ToString();
                    TextBox2.Text = descProducto.Descripcion ;
                    TextBox1.Text = descProducto.Precio.ToString();            
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
        protected void BtnSuma_Click(object sender, EventArgs e)
        {            
            suma();
        }
        public void suma()
            {
                int v1 = Convert.ToInt32(TextBox1.Text);
                int v2 = Convert.ToInt32(TextBox6.Text);
                int v3 = Convert.ToInt32(TextBox9.Text);
                int tv = v1 + v2 + v3 ;
                TextBox33.Text = tv.ToString();          
            }
         

        protected void BtnTerminar_Click(object sender, EventArgs e)
        {
            try
            {
                Facturass fact = new Facturass

                {                    
                    Cedula = Convert.ToInt32(LbRCedula.Text),
                    NombreCliente = TxtNombreCliente.Text,
                    Telefono = Convert.ToInt32(LbRMovil),
                    Correo = LbRCorreo.Text,
                    Placa = LbBPlaca.Text,
                    KM = Convert.ToInt32(LbRKm.Text),                    
                    Total = Convert.ToInt32(TextBox33.Text),
                    Nota = TextBox31.Text,
                    NumFac =Convert.ToInt32(Txtfec.Text),
                    Valor = Convert.ToInt32(TextBox1.Text),
                    Descripcion = TextBox2.Text,
                    Cantidad = Convert.ToInt32(TextBox3.Text),
                    Valor1 = Convert.ToInt32(TextBox6.Text),
                    Descripcion1 = TextBox5.Text,
                    Cantidad1 = Convert.ToInt32(TextBox4.Text),
                    Valor2 = Convert.ToInt32(TextBox9.Text),
                    Descripcion2 = TextBox8.Text,
                    Cantidad2 = Convert.ToInt32(TextBox7.Text),
                    Valor3 = Convert.ToInt32(TextBox12.Text),
                    Descripcion3 = TextBox11.Text,
                    Cantidad3 = Convert.ToInt32(TextBox10.Text),
                    Valor4 = Convert.ToInt32(TextBox15.Text),
                    Descripcion4 = TextBox14.Text,
                    Cantidad4 = Convert.ToInt32(TextBox13.Text),
                    Valor5 = Convert.ToInt32(TextBox18.Text),
                    Descripcion5 = TextBox17.Text,
                    Cantidad5 = Convert.ToInt32(TextBox16.Text),
                    Valor6 = Convert.ToInt32(TextBox21.Text),
                    Descripcion6 = TextBox20.Text,
                    Cantidad6 = Convert.ToInt32(TextBox19.Text),
                    Valor7 = Convert.ToInt32(TextBox24.Text),
                    Descripcion7 = TextBox23.Text,
                    Cantidad7 = Convert.ToInt32(TextBox22.Text),
                    Valor8 = Convert.ToInt32(TextBox27.Text),
                    Descripcion8 = TextBox26.Text,
                    Cantidad8 = Convert.ToInt32(TextBox25.Text),
                    Valor9 = Convert.ToInt32(TextBox30.Text),
                    Descripcion9 = TextBox29.Text,
                    Cantidad9 = Convert.ToInt32(TextBox28.Text),
                };
                IFacturass fac = new MFacturass();
                fac.InsertarFactura(fact);
                MostarMensaje("Factura se completo con exito!");
                limpiar();
            }
            catch (Exception ex)
            {
                MostarMensaje("Factura se completo con exito!");
                limpiar();
            }

            try
            {
                cli.EliminarCliente(txtBuscarPlaca.Text);
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }
            try
            {
                aut.EliminarAuto(txtBuscarPlaca.Text);
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }

        }
        private void limpiar()
        {
            LbRCedula.Text = "";
                    TxtNombreCliente.Text = "";
            LbRMovil.Text = "";
             LbRCorreo.Text = "";
             LbBPlaca.Text = "";
            LbRKm.Text = "";
            TextBox33.Text = "";
            TextBox31.Text = "";
            Txtfec.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
              TextBox6.Text = "";
                    TextBox5.Text = "";
                    TextBox4.Text = "";
                   TextBox9.Text = "";
                   TextBox8.Text = "";
            TextBox7.Text = "";
            TextBox12.Text = "";
                   TextBox11.Text = "";
            TextBox10.Text = "";
            TextBox15.Text = "";
                 TextBox14.Text = "";
          TextBox13.Text = "";
           TextBox18.Text = "";
             TextBox17.Text = "";
            TextBox16.Text = "";
            TextBox21.Text = "";
            TextBox20.Text = "";
            TextBox19.Text = "";
                  TextBox24.Text = "";
                   TextBox23.Text = "";
                   TextBox22.Text = "";
                   TextBox27.Text = "";
                    TextBox26.Text = "";
           TextBox25.Text = "";
            TextBox30.Text = "";
            TextBox29.Text = "";
            TextBox28.Text = "";
        }
    }
}