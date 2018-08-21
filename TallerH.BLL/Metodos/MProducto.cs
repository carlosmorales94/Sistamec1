using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;
using System.Transactions;

namespace TallerH.BLL.Metodos
{
    public class MProducto : IProducto
    {
        DAL.Interfaces.IProducto prod;
        public MProducto()
        {
            prod = new DAL.Metodos.MProducto();
        }

        public void Actualizar(Producto producto)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Metodos.MProducto.Instancia.Actualizar(producto);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public void InsertarProducto(Producto producto)
        {
            prod.InsertarProducto(producto);
        }

        public void ActualizarProducto(Producto producto)
        {
            prod.ActualizarProducto(producto);
        }

        public void EliminarProducto(int IdProducto)
        {
            prod.EliminarProducto(IdProducto);
        }
        public List<Producto> ListarProductos()
        {
            return prod.ListarProductos();
        }
        public Producto BuscarProducto(int idProducto)
        {
            return prod.BuscarProducto(idProducto);
        }

    }
}
