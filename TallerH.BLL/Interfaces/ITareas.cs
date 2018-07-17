using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.BLL.Interfaces
{
    public interface ITareas
    {
            List<Tareas> ListarTareas();
            void InsertarTareas(Tareas tareas);
            void EliminarTareas(string descripciontask);
        }
    
}
