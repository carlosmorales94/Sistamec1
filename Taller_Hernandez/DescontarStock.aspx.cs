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
    public partial class DescontarStock : System.Web.UI.Page
    {
        IDescProducto ds = new MDescProducto();
        private int cantidad;
        private string placa;
        private string desc="Aceite Freno";
        private int precio =500;
        private int id=1;
        IProducto prod = new MProducto();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    lvProductos.DataSource = prod.ListarProductos();
                    lvProductos.DataBind();
                }
            }
            catch (Exception ex)
            {
                MostarMensajeError("Ocurrio un error con la carga de materia" + ex.Message);
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

        protected void TxtcantS_TextChanged(object sender, EventArgs e)
        {
            TextBox TxtIPS = (TextBox)sender;
            cantidad = Convert.ToInt32(TxtIPS.Text);
            TxtIPS.Text = string.Empty;
            TxtIPS.Focus();

        }

        protected void BtnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                int idProducto = Convert.ToInt32(btn.CommandArgument);
                var producto = prod.BuscarProducto(idProducto);
                int cantidadDisponibles = producto.Cantidad - cantidad;
                if (cantidadDisponibles < 0)
                {
                    MostarMensajeError("Cantidad excede disponible");
                }
                else
                {
                    producto.Cantidad = cantidadDisponibles;
                    prod.ActualizarProducto(producto);
                    MostarMensaje("Producto(s) comprado(s)");
                }
            }
            catch (Exception ex)
            {
                MostarMensajeError("Ocurrio un error" + ex.Message);
            }
        }
        protected void txtPlacaS_TextChanged(object sender, EventArgs e)
        {
            TextBox txtPlacaS = (TextBox)sender;
            placa = txtPlacaS.Text;
            txtPlacaS.Text = string.Empty;
            txtPlacaS.Focus();
        }

        protected void BtnFactura_Click(object sender, EventArgs e)
        {
            try
            {
                DescProducto ds = new DescProducto
                {
                    IdProducto = id,
                    Precio = precio,
                    Descripcion = desc,
                    Placa = placa,
                    Cantidad = cantidad,
                };
                IDescProducto dsc = new MDescProducto();
                dsc.InsertarDescProducto(ds);
                MostarMensaje("Producto Insertado");
            }
            catch (Exception ex)
            {
                MostarMensajeError("Ocurrio un error insertar" + ex.Message);
            }
        }     
    }
}