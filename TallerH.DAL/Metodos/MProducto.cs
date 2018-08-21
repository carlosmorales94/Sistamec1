using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using System.Data;
using TallerH.DATA;
using TallerH.DAL.Interfaces;
using System.Data.Common;

namespace TallerH.DAL.Metodos
{
   public  class MProducto : IProducto
    {
        private static MProducto instancia;

        public static MProducto Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return new MProducto();
                }
                return instancia;
            }
            set
            {
                if (instancia == null)
                {
                    instancia = value;
                }
            }
        }

        public void Actualizar(Producto Producto)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(BD.Default.proveedor);
            DbConnection conn = null;
            DbCommand comm = null;

            try
            {
                conn = factory.CreateConnection();
                conn.ConnectionString = BD.Default.conexion;
                comm = factory.CreateCommand();

                DbParameter param1 = factory.CreateParameter();
                DbParameter param2 = factory.CreateParameter();



                //Carga de Parametros
                param1.ParameterName = "@Cantidad";
                param1.DbType = System.Data.DbType.Int32;
                param1.Value = Producto.Cantidad;

                param2.ParameterName = "@IdProducto";
                param2.DbType = System.Data.DbType.Int32;
                param2.Value = Producto.IdProducto;


                //Abrir Coneccion 
                comm.Connection = conn;
                conn.Open();

                //Ejecutar Store Procedure
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_ActualizarCant";
                comm.Parameters.Add(param1);
                comm.Parameters.Add(param2);


                comm.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                throw;
            }
            finally
            {
                comm.Dispose();
                conn.Dispose();
            }
        }

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

