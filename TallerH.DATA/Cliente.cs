using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using ServiceStack.DataAnnotations;

namespace TallerH.DATA
{
    [Alias("Cliente")]
    public class Cliente
    {
        public string Placa { get; set; }
        public int Movil { get; set; }
        public int Telefono { get; set; }
        public string NombreCliente { get; set; }
        public string Correo { get; set; }
        public int Cedula { get; set; }
    }
}
