using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using ServiceStack.DataAnnotations;

namespace TallerH.DATA
{
    [Alias("Modelo")]
    public class Modelo
    {
        public string DescripcionModelo { get; set; }
        public int IdModelo { get; set; }
    }
}
