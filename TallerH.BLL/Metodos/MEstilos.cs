using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;

namespace TallerH.BLL.Metodos
{
    public class MEstilos : IEstilos
    {
        DAL.Interfaces.IEstilos est;
        public MEstilos()
        {
            est = new DAL.Metodos.MEstilos();
        }
        public void EliminarEstilo(string Descripestilo)
        {
            est.EliminarEstilo(Descripestilo);
        }
        public void InsertarEstilo(Estilos estilo)
        {
            est.InsertarEstilo(estilo);

        }
        public List<Estilos> ListarEstilo()
        {
            return est.ListarEstilo();
        }
    }
}
