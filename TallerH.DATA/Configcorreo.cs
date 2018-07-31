using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using ServiceStack.DataAnnotations;

namespace TallerH.DATA
{
    [Alias("Configcorreo")]
    public class Configcorreo
    {
        public string Correo { get; set; }
        public string Pass { get; set; }
    }
}

