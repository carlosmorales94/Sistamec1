using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;

namespace TallerH.BLL.Metodos
{
   public class MFacturass : IFacturass
    {
       DAL.Interfaces.IFacturass fac;
            public MFacturass()
            {
                fac = new DAL.Metodos.MFacturass();
            }
            public void InsertarFactura(Facturass fact)
            {
            fac.InsertarFactura(fact);
            }
        }
}
