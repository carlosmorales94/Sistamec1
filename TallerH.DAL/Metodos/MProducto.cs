using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using System.Data;
using TallerH.DATA;
using TallerH.DAL.Interfaces;

namespace TallerH.DAL.Metodos
{
   public  class MProducto : IProducto
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MProducto()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public List<Producto> ListarProductos()
        {
            return _db.Select<Producto>();
        }

        public Producto BuscarProducto(int idProducto)
        {
            return _db.Select<Producto>(x => x.IdProducto == idProducto).FirstOrDefault();
        }

        public void InsertarProducto(Producto producto)
        {
            _db.Insert(producto);
        }

        public void ActualizarProducto(Producto producto)
        {
            _db.Update(producto);
        }

        public void EliminarProducto(int idProducto)
        {
            _db.Delete<Producto>(x => x.IdProducto == idProducto);
        }
    }
}

