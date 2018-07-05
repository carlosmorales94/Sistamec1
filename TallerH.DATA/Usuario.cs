using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;
namespace TallerH.DATA
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Factura { get; set; }
        public int Inventario { get; set; }
        public int Citas { get; set; }
        public int Configuracion { get; set; }
        public int Reportes { get; set; }
    }
}
