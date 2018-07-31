using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;

namespace TallerH.BLL.Metodos
{
     public class MConfigcorreo : IConfigcorreo
    {
        DAL.Interfaces.IConfigcorreo cor;
        public MConfigcorreo()
        {
            cor = new DAL.Metodos.MConfigcorreo();
        }
        public void ActualizarCorreo(Configcorreo configcorreo)
        {
            cor.ActualizarCorreo(configcorreo);
        }
    }
}
