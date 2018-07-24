using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.BLL.Interfaces
{
    public interface IMarca
    {
        List<Marca> ListarMarcas();
        void InsertarMarcas(Marca marca);
        void EliminarMarcas(string descripcionmarca);
    }
}
