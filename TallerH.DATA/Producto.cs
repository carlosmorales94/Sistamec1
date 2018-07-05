using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.DataAnnotations;
using System.Threading.Tasks;
namespace TallerH.DATA
{
    [Alias("Producto")]
    public class Producto
    {
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public int IdProducto { get; set; }
    }
}
