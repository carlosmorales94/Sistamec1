using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using ServiceStack.DataAnnotations;

namespace TallerH.DATA
{
    public class DescProducto
    {
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public string Placa { get; set; }
        public string Descripcion { get; set; }
        public int IdProducto { get; set; }
    }
}
