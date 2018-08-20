using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;

namespace TallerH.BLL.Metodos
{
    public class MContra : IContra
    {
        DAL.Interfaces.IContra ser;
        public MContra()
        {
            ser = new DAL.Metodos.MContra();
        }
        public void EliminarPrope(string Producto)
        {
            ser.EliminarPrope(Producto);
        }
        public void InsertarPrope(ProdContra prodContra)
        {
            ser.InsertarPrope(prodContra);

        }
        public List<ProdContra> ListarPrope()
        {
            return ser.ListarPrope();
        }
    }
}
