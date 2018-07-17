using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.DAL.Interfaces
{
    public interface ITareas
    {
        void InsertarTareas(Tareas tareas);
        void EliminarTareas(string descripciontask);
        List<Tareas> ListarTareas();
    }
}
