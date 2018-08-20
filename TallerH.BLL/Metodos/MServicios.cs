using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;

namespace TallerH.BLL.Metodos
{
    public class MServicios : IServicios
    {
        DAL.Interfaces.IServicios ser;
        public MServicios()
        {
            ser = new DAL.Metodos.MServicios();
        }
        public void EliminarServicio(string Servicio)
        {
            ser.EliminarServicio(Servicio);
        }
        public void InsertarServicio(Servicios servicios)
        {
            ser.InsertarServicio(servicios);

        }
        public List<Servicios> ListarServicio()
        {
            return ser.ListarServicio();
        }
    }
}
