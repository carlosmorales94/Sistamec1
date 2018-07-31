using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.BLL.Interfaces
{
    public interface IAno
    {
        List<Ano> ListarAno();
        void InsertarAno(Ano ano);
        void EliminarAno(int Descripano);
    }
}
