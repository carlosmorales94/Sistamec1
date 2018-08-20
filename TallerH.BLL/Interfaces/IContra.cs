using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.BLL.Interfaces
{
    public interface IContra
    {
        List<ProdContra> ListarPrope();
        void InsertarPrope(ProdContra prodContra);
        void EliminarPrope(string Producto);
    }
}

