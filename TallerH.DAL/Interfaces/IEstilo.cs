using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.DAL.Interfaces
{
    public interface IEstilo
    {
        List<Estilo> ListarEstilos();
        void InsertarEstilos(Estilo estilo);
        void EliminarEstilos(string descripcionestilo);
    }
}
