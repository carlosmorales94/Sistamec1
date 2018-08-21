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

namespace Taller_Hernandez.UI
{
    public partial class Ingreso_Stock : System.Web.UI.Page
    {
        TallerH.DATA.Producto config;

        IProducto prod = new MProducto();
        public int vcantn;
        public string vcant;
        public string vcantprod;
        public int vcantprodact;
        public string Vprecio;
        public string Vdescrip;
        public SqlConnection cn = new SqlConnection(@"Data Source=HP\SQLEXPRESS23;Initial Catalog=TallerHernandez;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Producto> listaProd = prod.ListarProductos();
            var vista = listaProd.Select(x => new { x.IdProducto, x.Descripcion, x.Precio, x.Cantidad }).ToList();
            Ggvpro.DataSource = vista;
            Ggvpro.DataBind();

            //Listar id prod Stock
            SqlCommand co = new SqlCommand("Select IdProducto from Producto;", cn);
            cn.Open();
            SqlDataReader dr = co.ExecuteReader();
            while (dr.Read() == true)
            {
                Drpidprod.Items.Add(dr[0].ToString());
            }
            cn.Close();

            //Listar id prod placas
            SqlCommand ce = new SqlCommand("Select Placa from Cita where Estado='Llegado';", cn);
            cn.Open();
            SqlDataReader de = ce.ExecuteReader();
            while (de.Read() == true)
            {
                Drpplaca.Items.Add(de[0].ToString());
            }
            cn.Close();

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
                    IdProducto = Convert.ToInt32(txtIdPro.Text)
                };
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
            TxtPrePro.Text = "";
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

        protected void BtnFactura_Click(object sender, EventArgs e)
        {
            Insert();
            update();
        }
        public void Insert()
        {
            //Carga cantidad de prod en stock
            SqlCommand ca = new SqlCommand("Select Cantidad from Producto where IdProducto='" + Convert.ToInt32(Drpidprod.Text) + "';", cn);
            cn.Open();
            SqlDataReader dec = ca.ExecuteReader();
            while (dec.Read() == true)
            {
                vcant = dec[0].ToString();
            }
            cn.Close();

            //------------Insert--------------------
            SqlCommand cop = new SqlCommand("Select Precio from Producto where IdProducto='" + Convert.ToInt32(Drpidprod.Text) + "';", cn);
            cn.Open();
            SqlDataReader drp = cop.ExecuteReader();
            while (drp.Read() == true)
            {
                Vprecio = drp[0].ToString();
            }
            cn.Close();

            SqlCommand cod = new SqlCommand("Select Descripcion from Producto where IdProducto='" + Convert.ToInt32(Drpidprod.Text) + "';", cn);
            cn.Open();
            SqlDataReader drd = cod.ExecuteReader();
            while (drd.Read() == true)
            {
                Vdescrip = drd[0].ToString();
            }
            cn.Close();
            try
            {
                DescProducto ds = new DescProducto
                {
                    IdProducto = Convert.ToInt32(Drpidprod.Text),
                    Precio = Convert.ToInt32(Vprecio),
                    Descripcion = Vdescrip,
                    Placa = Drpplaca.Text,
                    Cantidad = Convert.ToInt32(TxtcantS.Text),
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

        private void GetValues()
        {
            SqlCommand coc = new SqlCommand("Select Cantidad from Producto where IdProducto='" + Convert.ToInt32(Drpidprod.Text) + "';", cn);
            cn.Open();
            SqlDataReader drc = coc.ExecuteReader();
            while (drc.Read() == true)
            {
                vcantprod = drc[0].ToString();
            }
            vcantprodact = (Convert.ToInt32(vcantprod))- (Convert.ToInt32(TxtcantS.Text));
            config = new TallerH.DATA.Producto
            {
                Cantidad = vcantprodact,
                IdProducto = Convert.ToInt32(Drpidprod.Text)

            };
        }

        public void update()
        {
            //------------Update--------------------------------------
            try
            {
                GetValues();
                prod.Actualizar(config);
                TxtcantS.Text = "";
            }
            catch (Exception ee)
            {
                throw;
            }
        }
    }
}


