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
        public string NombreCliente { get; set; }
        public int Movil { get; set; }
        public string Correo { get; set; }
        public string Marca { get; set; }
        public string ProVeh { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Placa { get; set; }
    }
}
