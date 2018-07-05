using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using ServiceStack.DataAnnotations;

namespace TallerH.DATA
{
    [Alias("Auto")]
    public class Auto
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Estilo { get; set; }
        public int Ano { get; set; }
        public string ProblemasVehiculo { get; set; }
        public string DanosVehiculo { get; set; }
        public string MantenimientoPrevio { get; set; }
        public string RevisionIntervalos { get; set; }
        public int KM { get; set; }
        public int Bin { get; set; }
        public string Nota { get; set; }
    }
}
