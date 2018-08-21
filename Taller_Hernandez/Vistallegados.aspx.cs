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

    public partial class Vistallegados : System.Web.UI.Page
    {
        TallerH.DATA.Cita cita;
        private string vfec = DateTime.Now.ToShortDateString(); 
        private string vfecha1;                                                  
        private string vfecha;

        public SqlConnection cn = new SqlConnection(@"Data Source=HP\SQLEXPRESS23;Initial Catalog=TallerHernandez;Integrated Security=True");
        ICita cit = new MCita();
        MCita procesar = new MCita();

        protected void Page_Load(object sender, EventArgs e)
        {
            vfecha1 =vfec.Substring(6,4)+vfec.Substring(2,4)+ vfec.Substring(0,2);
            vfecha = vfecha1.Replace('/', '-');

            SqlCommand ca = new SqlCommand
            ("Select Cedula, Descripmarca, ProVeh, FechaIngreso, Placa, Descripestilo, Descripano, Nota, Bin, Km, RevisionIntervalos, MantenimientoPrevio,DanosVehiculo, Estado from Cita where Estado='Llegado' and FechaIngreso='"+vfecha+"';", cn);
            cn.Open();
            SqlDataReader da = ca.ExecuteReader();
            while (da.Read() == true)
            {
                Ggvcitas.DataSource = da;
                Ggvcitas.DataBind();
            }
            cn.Close();
            //carga boton llegado
            SqlCommand ce = new SqlCommand("Select Placa from Cita where Estado='Llegado' and FechaIngreso='" + vfecha + "';", cn);
            cn.Open();
            SqlDataReader de = ce.ExecuteReader();
            while (de.Read() == true)
            {
                Drpplaca .Items.Add(de[0].ToString());
            }
            cn.Close();
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

        protected void Btnllegado_Click(object sender, EventArgs e)
        {
            update();
        }

        protected void Clcita_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Drpfecha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void GetValues()
        {
            cita = new TallerH.DATA.Cita
            {
                Placa = Drpplaca .Text

            };
        }

        public void update()
        {
            //------------Update--------------------------------------
            try
            {
                GetValues();
                procesar.Actualizar(cita);
            }
            catch (Exception ee)
            {
                throw;
            }
        }

    }
}