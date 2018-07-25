using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.DAL.Interfaces
{
    public interface IModelo
    {
        List<Modelo> ListarModelos();
        void InsertarModelos(Modelo modelo);
        void EliminarModelos(string descripcionmodelo);
    }
}
