using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;

namespace TallerH.BLL.Metodos
{
    public class MMarca : IMarca
    {
        DAL.Interfaces.IMarca mar;
        public MMarca()
        {
            mar = new DAL.Metodos.MMarca();
        }
        public void EliminarMarca(string Descripmarca)
        {
            mar.EliminarMarca(Descripmarca);
        }
        public void InsertarMarca(Marca marca)
        {
            mar.InsertarMarca(marca);

        }
        public List<Marca> ListarMarca()
        {
            return mar.ListarMarca();
        }
    }
}
