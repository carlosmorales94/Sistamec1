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
    public class MConfigcorreo : IConfigcorreo
    {

        private static MConfigcorreo instancia;

        public static MConfigcorreo Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return new MConfigcorreo();
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




        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MConfigcorreo()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void Actualizar(Configcorreo config)
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
                param1.ParameterName = "@Correo";
                param1.DbType = System.Data.DbType.String;
                param1.Value = config.Correo;

                param2.ParameterName = "@Pass";
                param2.DbType = System.Data.DbType.String;
                param2.Value = config.Pass;

               
                //Abrir Coneccion 
                comm.Connection = conn;
                conn.Open();

                //Ejecutar Store Procedure
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_Actualizar";
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

        public void ActualizarCorreo(Configcorreo configcorreo)
        {
            _db.Update(configcorreo);
        }
        public List<Configcorreo> ListarCorreo()
        {
            return _db.Select<Configcorreo>();
        }
    }
}
