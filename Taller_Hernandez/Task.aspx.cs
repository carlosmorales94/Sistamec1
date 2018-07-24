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
    public partial class Task : System.Web.UI.Page
    {
        ITareas tas = new MTareas();
        protected void Page_Load(object sender, EventArgs e)
        {
            ITareas tas = new MTareas();
            List<Tareas> ListarTareas = tas.ListarTareas();
            var lista = ListarTareas.Select(x => new { x.IdTask });

            try
            {
                if (!Page.IsPostBack)
                {
                    lvTareas.DataSource = tas.ListarTareas();
                    lvTareas.DataBind();
                }
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }

        }
        private void Limpiar()
        {
           TxtTarea.Text = "";
        }
        private void Limpiar1()
        {
            TxtCodTarea.Text = "";
        }
        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                tas.EliminarTareas ( TxtCodTarea .Text);
                MostarMensaje("Tarea Eliminada");
                Limpiar1();
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
                Limpiar1();
            }

        }
        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Tareas tareas = new Tareas
                {
                    Descripciontask =  TxtTarea .Text
                };
                tas.InsertarTareas(tareas);
                MostarMensaje("Tarea se registro con exito");
                Limpiar();
    }

            catch(Exception)
            {
                MostarMensajeError("Ocurrio un error, existen campos en blanco");
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
    }
}