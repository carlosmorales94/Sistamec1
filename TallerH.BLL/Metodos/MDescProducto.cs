using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;

namespace TallerH.BLL.Metodos
{
    public class MDescProducto : IDescProducto
    {
        DAL.Interfaces.IDescProducto des;
        public MDescProducto()
        {
            des = new DAL.Metodos.MDescProducto();
        }
        public void InsertarDescProducto(DescProducto descProducto)
        {
            des.InsertarDescProducto(descProducto);

        }
        public DescProducto BuscarDescProducto(string placa)
        {
            return des.BuscarDescProducto(placa);
        }
       
    }
}