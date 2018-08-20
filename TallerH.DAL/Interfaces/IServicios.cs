using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.DAL.Interfaces
{
    public interface IServicios
    {
        List<Servicios> ListarServicio();
        void InsertarServicio(Servicios servicios);
        void EliminarServicio(string Servicio);
    }
}
