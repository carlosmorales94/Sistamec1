using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.BLL.Interfaces
{
    public interface IEstilos
    {
        List<Estilos> ListarEstilo();
        void InsertarEstilo(Estilos estilo);
        void EliminarEstilo(string descripestilo);
    }
}
