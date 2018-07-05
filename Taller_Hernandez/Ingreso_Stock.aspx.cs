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

namespace Taller_Hernandez.UI
{
    public partial class Ingreso_Stock : System.Web.UI.Page
    {
        private int cantidad;
        IProducto prod = new MProducto();
        protected void Page_Load(object sender, EventArgs e)
        {
            //divMantenimiento.Visible = false;
        }
       
        protected void BtnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto
                {
                    Descripcion = TxtDesPro.Text,
                    Precio = Convert.ToInt32(TxtPrePro.Text),
                    Cantidad = Convert.ToInt32(TxtCanPro.Text),
                    IdProducto=Convert.ToInt32(txtIdPro.Text)                    
                };
                IProducto prod = new MProducto();
                prod.InsertarProducto(producto);
                MostarMensaje("Producto Insertado");
                limpiar();
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
                limpiar();
            }
        }

        private void limpiar()
        {
            TxtDesPro.Text = "";
            TxtCanPro.Text = "";
            TxtPrePro.Text="";
            TxtBusIdPro.Text = "";
            txtIdPro.Text = "";

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

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto
                {
                    Cantidad = Convert.ToInt32(TxtCanPro.Text),
                    Precio = Convert.ToInt32(TxtPrePro.Text),
                    Descripcion = TxtDesPro.Text,
                   
                };
                IProducto prod = new MProducto();
                prod.ActualizarProducto(producto);
                MostarMensaje("Producto Modificado Exitosamente");
                limpiar();
            }
            catch
            {
                MostarMensajeError("Ocurrio un error al modificar el producto del Stock");
                limpiar();
            }

        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
               prod.EliminarProducto(Convert.ToInt32(TxtBusIdPro.Text));
                MostarMensaje("Producto eliminado del Stock");
                limpiar();
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error al eliminar el producto del Stock");
                limpiar();
            }
            

        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = prod.BuscarProducto(Convert.ToInt32(TxtBusIdPro.Text));

                if (producto != null)
                {
                    TxtDesPro.Text = producto.Descripcion;
                    TxtCanPro.Text = producto.Cantidad.ToString();
                    TxtPrePro.Text = producto.Precio.ToString();
                }
                else
                {
                    MostarMensajeError("El producto no existe");
                    limpiar();
                }
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
                limpiar();
            }
        }

        protected void BtnSacar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Button btn = (Button)sender;
            //    int id = Convert.ToInt32(btn.CommandArgument);
            //    var producto = prod.BuscarProducto(id);
            //    int cantidadDisponibles = producto.Cantidad - cantidad;
            //    if (cantidadDisponibles < 0 )
            //    {
            //        MostarMensajeError("Cantidad excede disponible");
            //    }
            //    else
            //    {
            //        producto.Cantidad = cantidadDisponibles;
            //        prod.ActualizarProducto(producto);
            //        MostarMensaje("Producto fue insertado en la factura con exito");
            //    }
            //}
            //catch(Exception)
            //{
            //    MostarMensajeError("Ocurrio un error");
            //}

        }
    }
}
        
    
