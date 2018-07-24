using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using ServiceStack.DataAnnotations;

namespace TallerH.DATA
{
    [Alias("Marca")]
    public class Marca
    {
        public string DescripcionMarca { get; set; }
        public int IdMarca { get; set; }
    }
}
