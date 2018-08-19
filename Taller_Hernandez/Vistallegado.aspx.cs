using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TallerH.BLL.Interfaces;
using TallerH.BLL.Metodos;
using TallerH.DATA;

namespace Taller_Hernandez
{

    public partial class Vistallegado : System.Web.UI.Page
    {
        private string vfecllega = DateTime.Now.ToShortDateString(); 
        private string vfechallega1;                                                  
        private string vfechallega;

        public SqlConnection cnl = new SqlConnection(@"Data Source=HP\SQLEXPRESS23;Initial Catalog=TallerHernandez;Integrated Security=True");
        ICita cit = new MCita();

        protected void Page_Load(object sender, EventArgs e)
        {
            vfechallega1 = vfecllega.Substring(6,4)+ vfecllega.Substring(2,4)+ vfecllega.Substring(0,2);
            vfechallega = vfechallega1.Replace('/', '-');

            SqlCommand ca = new SqlCommand
            ("Select Cedula, Marca, ProVeh, FechaIngreso, Placa, Estilo, Ano, Nota, Bin, Km, RevisionIntervalos, MantenimientoPrevio,DanosVehiculo, Estado from Cita where Estado='Llegado' and FechaIngreso='"+ vfechallega +"';", cnl);
            cnl.Open();
            SqlDataReader da = ca.ExecuteReader();
            while (da.Read() == true)
            {
                //Ggvcitas.DataSource = da;
               // Ggvcitas.DataBind();
            }
            cnl.Close();

            //carga boton llegado
            //SqlCommand ce = new SqlCommand("Select Placa from Cita where Estado='Llegado' and FechaIngreso='" + vfechallega + "';", cnl);
            //cnl.Open();
            //SqlDataReader de = ce.ExecuteReader();
            //while (de.Read() == true)
            //{
            //    Drpplaca.Items.Add(de[0].ToString());
            //}
            //cnl.Close();
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