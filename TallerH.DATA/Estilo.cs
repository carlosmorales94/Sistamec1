using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using ServiceStack.DataAnnotations;

namespace TallerH.DATA
{
    [Alias("Estilo")]
    public class Estilo
    {
        public string DescripcionEstilo { get; set; }
        public int IdEstilo { get; set; }
    }
}
