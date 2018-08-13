using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.DAL.Interfaces
{
    public interface IConfigcorreo
    {
        void ActualizarCorreo(Configcorreo configcorreo);
        void Actualizar(Configcorreo config);
        List<Configcorreo> ListarCorreo();
    }
}
