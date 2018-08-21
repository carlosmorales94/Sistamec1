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
using System.Data.SqlClient;
using System.Data;

namespace Taller_Hernandez
{
    public partial class Factura : System.Web.UI.Page
    {
        public string vnunf;
        public SqlConnection cn = new SqlConnection(@"Data Source=HP\SQLEXPRESS23;Initial Catalog=TallerHernandez;Integrated Security=True");
        //IDescProducto ds = new MDescProducto();
        //ICliente cli = new MCliente();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cop = new SqlCommand("Select Placa from cita where Estado='Llegado';", cn);
            cn.Open();
            SqlDataReader drp = cop.ExecuteReader();
            while (drp.Read() == true)
            {
                 drpBuscarPlaca.Items.Add(drp[0].ToString());
            }
            cn.Close();



            SqlCommand con = new SqlCommand(" SELECT MAX(NumFac) FROM Factura;", cn);
            cn.Open();
            SqlDataReader drn = con.ExecuteReader();
            while (drn.Read() == true)
            {
                vnunf = drn[0].ToString();
                Txtfec.Text = vnunf + 1;
            }
            cn.Close();
        }
        //private void MostarMensaje(string texto)
        //{
        //    mensaje.Visible = true;
        //    mensajeError.Visible = false;
        //    textoMensajeError.InnerHtml = string.Empty;
        //    textoMensaje.InnerHtml = texto;
        //}

        //private void MostarMensajeError(string texto)
        //{
        //    mensaje.Visible = false;
        //    mensajeError.Visible = true;
        //    textoMensajeError.InnerHtml = texto;
        //    textoMensaje.InnerHtml = string.Empty;
        //}

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            //try
            //{
               // var descProducto= ds.BuscarDescProducto(txtBuscarPlaca.Text);
                //var auto = aut.BuscarAuto(txtBuscarPlaca.Text);
               // var cliente = cli.BuscarCliente(txtBuscarPlaca.Text);
             //   if (auto != null)
             //   {
                  //  LbRCorreo.Text = cliente.Correo;
                  //  LbRMovil.Text = cliente.Movil.ToString(); 
                 //   LbRMarca.Text = auto.Marca;
                 //   LbRPlaca.Text = auto.Placa;
                 //   TxtNombreCliente.Text = cliente.NombreCliente;
                 //   LbRKm.Text = auto.KM.ToString();
                  //  LbRCedula.Text = cliente.Cedula.ToString();

              //      TextBox3.Text = descProducto.Cantidad.ToString();
              //      TextBox2.Text = descProducto.Descripcion ;
             //       TextBox1.Text = descProducto.Precio.ToString();            
             //    }
            //    else
            //    {
            //        MostarMensajeError("El auto no existe");
            //    }
            //}
            //catch (Exception)
            //{
            //    MostarMensajeError("Ocurrio un error");
            //}

                  //  TextBox3.Text = descProducto.Cantidad.ToString();
                   // TextBox2.Text = descProducto.Descripcion ;
                   // TextBox1.Text = descProducto.Precio.ToString();            
                //  }
                //else
                //{
                 //   MostarMensajeError("El auto no existe");
            //    }
            //}
            //catch (Exception)
            //{
            //    MostarMensajeError("Ocurrio un error");
            //}

        }



        protected void Btn_facelec_Click(object sender, EventArgs e)
        {
    System.Diagnostics.Process.Start(@"C:\Users\USUARIO\Documents\Releases\FacturaElectronicaCR-master\FacturaElectronicaCR_VB\bin\Debug\FacturaElectronicaCR_VB.exe");
        }

        protected void BtnTerminar_Click(object sender, EventArgs e)
        {

        }
        //{
        //    try
        //    {
        //        Facturass fact = new Facturass

        //        {                    
        //            Cedula = Convert.ToInt32(LbRCedula.Text),
        //            NombreCliente = TxtNombreCliente.Text,
        //            Telefono = Convert.ToInt32(LbRMovil),
        //            Correo = LbRCorreo.Text,
        //            Placa = LbBPlaca.Text,
        //            KM = Convert.ToInt32(LbRKm.Text),                    
        //            NumFac =Convert.ToInt32(Txtfec.Text),
        //        };
        //        IFacturass fac = new MFacturass();
        //        fac.InsertarFactura(fact);
        //        MostarMensaje("Factura se completo con exito!");
        //        limpiar();
        //    }
        //    catch (Exception ex)
        //    {
        //        MostarMensaje("Factura se completo con exito!");
        //        limpiar();
        //    }

        //    try
        //    {
        //      //  cli.EliminarCliente(txtBuscarPlaca.Text);
        //    }
        //    catch (Exception)
        //    {
        //        MostarMensajeError("Ocurrio un error");
        //    }
        //    try
        //    {
        //        //aut.EliminarAuto(txtBuscarPlaca.Text);
        //    }
        //    catch (Exception)
        //    {
        //        MostarMensajeError("Ocurrio un error");
        //    }

        //}
        //private void limpiar()
        //{
        //    LbRCedula.Text = "";
        //     TxtNombreCliente.Text = "";
        //    LbRMovil.Text = "";
        //     LbRCorreo.Text = "";
        //     LbBPlaca.Text = "";
        //    LbRKm.Text = "";
      //  }
    }
}