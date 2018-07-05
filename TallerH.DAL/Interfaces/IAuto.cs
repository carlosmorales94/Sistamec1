using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.DAL.Interfaces
{
    public  interface IAuto
    {
        List<Auto> ListarAutos();
        void ActualizarAuto(Auto auto);
        Auto BuscarAuto(string placa);
        void InsertarAuto(Auto auto);
        void EliminarAuto(string placa);
    }
}
