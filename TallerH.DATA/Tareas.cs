using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using ServiceStack.DataAnnotations;

namespace TallerH.DATA
{
    [Alias("Tareas")]
    public class Tareas
    {
        public string Descripciontask { get; set; }
        public int IdTask { get; set; }

    }
}
