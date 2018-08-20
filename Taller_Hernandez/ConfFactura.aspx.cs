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
    public partial class ConfFactura : System.Web.UI.Page
    {
        IServicios vser = new MServicios();
        IContra vprod = new MContra();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Se listan los servicios
            IServicios van = new MServicios();
            List<Servicios> listarServicio = van.ListarServicio();
            var vistaano = listarServicio.Select(x => new { x.Servicio }).ToList();
            Gbservicio.DataSource = vistaano;
            Gbservicio.DataBind();

            // se listan los productos
            IContra vest = new MContra();
            List<ProdContra> listarProd = vest.ListarPrope();
            var vistaest = listarProd.Select(x => new { x.Producto }).ToList();
            Gbvprod.DataSource = vistaest;
            Gbvprod.DataBind();

        }
        protected void Btnelipro_Click(object sender, EventArgs e)
        {
            try
            {
                vprod.EliminarPrope(Txtelipro.Text);
                MostarMensaje("Producto Eliminado");
                Limpiartxt();
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
                Limpiartxt();
            }
        }
        protected void BtneliServi_Click(object sender, EventArgs e)
        {
            try
            {
                vser.EliminarServicio(Txteliservi.Text);
                MostarMensaje("Servicio Eliminado");
                Limpiartxt();
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
                Limpiartxt();
            }
        }

        protected void BtnAceptarser_Click(object sender, EventArgs e)
        {
            try
            {
                Servicios ser = new Servicios
                {
                         Servicio = Txtservicio .Text
                };
                vser.InsertarServicio (ser);
                MostarMensaje("Servicio se registro con exito");
                Limpiartxt();
            }

            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error, existen campos en blanco");
                Limpiartxt();
            }
        }
        protected void BtnAceptarpro_Click(object sender, EventArgs e)
        {
            try
            {
                ProdContra prod = new ProdContra
                {
                    Producto = Txtprodu .Text
                };
                vprod.InsertarPrope(prod);
                MostarMensaje("Se registro el Producto");
                Limpiartxt();
            }

            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error, no se registro el producto");
                Limpiartxt();
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
        private void Limpiartxt()
        {
            //Txtestilo.Text = "";
            //Txtmarca.Text = "";
            //Txtano.Text = "";
            //Txteliano.Text = "";
            //Txteliestilo.Text = "";
            //Txtelimarca.Text = "";
        }
    }
}