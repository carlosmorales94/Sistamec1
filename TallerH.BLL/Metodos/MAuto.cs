using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;

namespace TallerH.BLL.Metodos
{
    public class MAuto : IAuto
    {
        DAL.Interfaces.IAuto aut;
        public MAuto()
        {
            aut = new DAL.Metodos.MAuto();
        }
        public void InsertarAuto(Auto auto)
        {
            aut.InsertarAuto(auto);

        }
        public Auto BuscarAuto(string placa)
        {
            return aut.BuscarAuto(placa);
        }
        public void ActualizarAuto(Auto auto)
        {
            aut.ActualizarAuto(auto);
        }

        public void EliminarAuto(string placa)
        {
            aut.EliminarAuto(placa);
        }
        public List<Auto> ListarAutos()
        {
            return aut.ListarAutos();
        }
    }
}
