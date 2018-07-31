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
    public partial class ConfCita : System.Web.UI.Page
    {
        IMarca vmar = new MMarca();
        IAno vano = new MAno();
        IEstilos vest = new MEstilos();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Se listan los años
            IAno van = new MAno();
            List<Ano> listarAno = van.ListarAno();
            var vistaano = listarAno.Select(x => new { x.Descripano }).ToList();
            Gbvano.DataSource = vistaano;
            Gbvano.DataBind();
            // se listan los estilo
            IEstilos vest = new MEstilos();
            List<Estilos> listarEstilo = vest.ListarEstilo();
            var vistaest = listarEstilo.Select(x => new { x.Descripestilo }).ToList();
            Gbgestilo.DataSource = vistaest;
            Gbgestilo.DataBind();
            // se listan las marcas
            IMarca vmar = new MMarca();
            List<Marca> listarMarca = vmar.ListarMarca();
            var vistamar = listarMarca.Select(x => new { x.Descripmarca }).ToList();
            Ggvmarca.DataSource = vistamar;
            Ggvmarca.DataBind();
        }
        protected void BtnElimarca_Click(object sender, EventArgs e)
        {
            try
            {
                vmar.EliminarMarca(Txtelimarca.Text);
                MostarMensaje("Marca Eliminada");
                Limpiartxt();
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
                Limpiartxt();
            }
        }
        protected void BtnEliano_Click(object sender, EventArgs e)
        {
            try
            {
                vano.EliminarAno(Convert.ToInt32(Txteliano.Text));
                MostarMensaje("Año Eliminado");
                Limpiartxt();
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
                Limpiartxt();
            }
        }
        protected void BtnEliestilo_Click(object sender, EventArgs e)
        {
            try
            {
                vest.EliminarEstilo(Txteliestilo.Text);
                MostarMensaje("Estilo Eliminado");
                Limpiartxt();
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
                Limpiartxt();
            }
        }
        protected void BtnAceptarmar_Click(object sender, EventArgs e)
        {
            try
            {
                Marca marca = new Marca
                {
                    Descripmarca = Txtmarca.Text
                };
                vmar.InsertarMarca(marca);
                MostarMensaje("Marca se registro con exito");
                Limpiartxt();
            }

            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error, existen campos en blanco");
                Limpiartxt();
            }
        }
        protected void BtnAceptarano_Click(object sender, EventArgs e)
        {
            try
            {
                Ano ano = new Ano
                {
                    Descripano = Convert.ToInt32(Txtano.Text)
                };
                vano.InsertarAno(ano);
                MostarMensaje("Año se registro con exito");
                Limpiartxt();
            }

            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error, existen campos en blanco");
                Limpiartxt();
            }
        }
        protected void BtnAceptarest_Click(object sender, EventArgs e)
        {
            try
            {
                Estilos estilo = new Estilos
                {
                    Descripestilo = Txtestilo.Text
                };
                vest.InsertarEstilo(estilo);
                MostarMensaje("Estilo se registro con exito");
                Limpiartxt();
            }

            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error, existen campos en blanco");
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
            Txtestilo.Text = "";
            Txtmarca.Text = "";
            Txtano.Text = "";
            Txteliano.Text = "";
            Txteliestilo.Text = "";
            Txtelimarca.Text = "";
        }
    }
}