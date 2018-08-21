using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DAL.Interfaces;
using TallerH.DATA;
using System.Data;
using ServiceStack.OrmLite;
using System.Data.Common;

namespace TallerH.DAL.Metodos
{
    public class MUsuario : IUsuario
    {

        private static MUsuario instancia;

        public static MUsuario Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return new MUsuario();
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

        public Usuario BuscarUsuario(string usuario, string contra)
        {
            throw new NotImplementedException();
        }




        /* public void Insertar(DATA.Usuario usuario)
         {
             DbProviderFactory factory = DbProviderFactories.GetFactory(BD.Default.proveedor);

             DbConnection conn = null;

             DbCommand comm = null;



             try
             {

                 conn = factory.CreateConnection();

                 conn.ConnectionString = BD.Default.conexion;

                 comm = factory.CreateCommand();



                 // DbParameter param1 = factory.CreateParameter();

                 DbParameter param2 = factory.CreateParameter();

                 DbParameter param3 = factory.CreateParameter();

                 DbParameter param4 = factory.CreateParameter();

                 DbParameter param5 = factory.CreateParameter();

                 DbParameter param6 = factory.CreateParameter();




                 //Carga de Parametros

                 /* param1.ParameterName = "@iID";

                  param1.DbType = System.Data.DbType.Int32;

                  param1.Value = ropa.IID;






                 param2.ParameterName = "@Username";

                 param2.DbType = System.Data.DbType.String;

                 param2.Value = usuario.Username;





                 param3.ParameterName = "@Password";

                 param3.DbType = System.Data.DbType.String;

                 param3.Value = usuario.Password;


                 param4.ParameterName = "@IdPerfil";

                 param4.DbType = System.Data.DbType.String;

                 param4.Value = usuario.IdPerfil;












                 //Abrir Coneccion 

                 comm.Connection = conn;

                 conn.Open();



                 //Ejecutar Store Procedure

                 comm.CommandType = System.Data.CommandType.StoredProcedure;

                 comm.CommandText = "sp_Insertar";

                 // comm.Parameters.Add(param1);

                 comm.Parameters.Add(param2);

                 comm.Parameters.Add(param3);

                 comm.Parameters.Add(param4);



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
         }*/




        /* private OrmLiteConnectionFactory _conexion;
         private IDbConnection _db;
         public MUsuario()
         {
             _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                 SqlServerDialect.Provider);
             _db = _conexion.Open();
         }
         public Usuario BuscarUsuario(string usuario, string contra)
         {
             return _db.Select<Usuario>(x => x.Username == usuario && x.Password == contra).FirstOrDefault();
         }*/

        public void InsertarUsuario(Usuario usuario)
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

                DbParameter param3 = factory.CreateParameter();

                DbParameter param4 = factory.CreateParameter();

                DbParameter param5 = factory.CreateParameter();

                DbParameter param6 = factory.CreateParameter();
                DbParameter param7 = factory.CreateParameter();
                DbParameter param8 = factory.CreateParameter();




                //Carga de Parametros

                /* param1.ParameterName = "@iID";

                 param1.DbType = System.Data.DbType.Int32;

                 param1.Value = ropa.IID;*/






                param1.ParameterName = "@Username";

                param1.DbType = System.Data.DbType.String;

                param1.Value = usuario.Username;





                param2.ParameterName = "@Password";

                param2.DbType = System.Data.DbType.String;

                param2.Value = usuario.Password;


                param3.ParameterName = "@Ingreso";

                param3.DbType = System.Data.DbType.Int32;

                param3.Value = usuario.Ingreso;


                param4.ParameterName = "@Factura";
                param4.DbType = System.Data.DbType.Int32;
                param4.Value = usuario.Factura;

                param5.ParameterName = "@Inventario";
                param5.DbType = System.Data.DbType.Int32;
                param5.Value = usuario.Inventario;

                param6.ParameterName = "@Citas";
                param6.DbType = System.Data.DbType.Int32;
                param6.Value = usuario.Citas;

                param7.ParameterName = "@Configuracion";
                param7.DbType = System.Data.DbType.Int32;
                param7.Value = usuario.Configuracion;

                param8.ParameterName = "@Reportes";
                param8.DbType = System.Data.DbType.Int32;
                param8.Value = usuario.Reportes;












                //Abrir Coneccion 

                comm.Connection = conn;

                conn.Open();



                //Ejecutar Store Procedure

                comm.CommandType = System.Data.CommandType.StoredProcedure;

                comm.CommandText = "sp_Inserta";

                // comm.Parameters.Add(param1);
                comm.Parameters.Add(param1);

                comm.Parameters.Add(param2);

                comm.Parameters.Add(param3);

                comm.Parameters.Add(param4);
                comm.Parameters.Add(param5);
                comm.Parameters.Add(param6);
                comm.Parameters.Add(param7);
                comm.Parameters.Add(param8);


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
        /* public void InsertarUsuario(DATA.Usuario usuario)
{
    _db.Insert(usuario);
}*/
    }
}
