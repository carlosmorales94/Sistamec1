using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;

namespace TallerH.BLL.Metodos
{
    public class MAno : IAno
    {
        DAL.Interfaces.IAno vano;
        public MAno()
        {
            vano = new DAL.Metodos.MAno();
        }
        public void EliminarAno(int Descripano)
        {
            vano.EliminarAno(Descripano);
        }
        public void InsertarAno(Ano ano)
        {
            vano.InsertarAno(ano);

        }
        public List<Ano> ListarAno()
        {
            return vano.ListarAno();
        }
    }
}
