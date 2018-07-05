using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.BLL.Interfaces
{
    public interface IDescProducto
    {
        DescProducto BuscarDescProducto(string placa);
        void InsertarDescProducto(DescProducto descProducto);

    }
}
