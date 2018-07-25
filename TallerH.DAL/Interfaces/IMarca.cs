using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.DAL.Interfaces
{
    public interface IMarca
    {
        List<Marca> ListarMarca();
        void InsertarMarca(Marca marca);
        void EliminarMarca(string descripcionmarca);
    }
}
