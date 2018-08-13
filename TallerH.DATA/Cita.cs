using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using ServiceStack.DataAnnotations;

namespace TallerH.DATA
{
    [Alias("Cita")]
    public class Cita
    {
        public int Cedula { get; set; }
        public string Marca { get; set; }
        public string ProVeh { get; set; }
        public string FechaIngreso { get; set; }
        public string Placa { get; set; }
        public string Estilo { get; set; }
        public int Ano { get; set; }
        public string Nota { get; set; }
        public int Bin { get; set; }
        public int KM { get; set; }
        public string RevisionIntervalos { get; set; }
        public string MantenimientoPrevio { get; set; }
        public string Estado { get; set; }
        public string DanosVehiculo { get; set; }
}
}
