using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;

namespace TallerH.BLL.Metodos
{
    public class MTareas : ITareas
    {
        DAL.Interfaces.ITareas tas;
        public MTareas()
        {
            tas = new DAL.Metodos.MTareas();
        }
        public void EliminarTareas(string descripciontask)
        {
            tas.EliminarTareas(descripciontask);
        }
        public void InsertarTareas(Tareas tareas)
        {
            tas.InsertarTareas(tareas);

        }
        public List<Tareas> ListarTareas()
        {
            return tas.ListarTareas();
        }
    }
}
