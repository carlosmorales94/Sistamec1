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
    public class MCita : ICita
    {

        private static MCita instancia;

        public static MCita Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return new MCita();
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
        public void Actualizar(Cita cita)
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

                //Carga de Parametros
                param1.ParameterName = "@Placa";
                param1.DbType = System.Data.DbType.String;
                param1.Value = cita.Placa;

                //Abrir Coneccion 
                comm.Connection = conn;
                conn.Open();

                //Ejecutar Store Procedure
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_ActualizaEstado";
                comm.Parameters.Add(param1);

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
        public MCita()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public List<Cita> ListarCita(string fechaingreso)
        {
            return _db.Select<Cita>();
        }

        public void InsertarCita(Cita cita)
        {
            _db.Insert(cita);
        }

        public List<Cita> ListarCitaDatos()
        {
            return _db.Select<Cita>();
        }

        public List<Cita> ListarCitaListarCitaDatos()
        {
            return _db.Select<Cita>();
        }

        public Cita BuscarCita(string fechaingreso)
        {
            return _db.Select<Cita>(x => x.FechaIngreso == fechaingreso).FirstOrDefault();
        }
        public void ActualizarCita(Cita cita)
        {
            _db.Update(cita);
        }

        //public Cita ActualizarCitaestado(string estado)
        //{
        //   return _db.Update<Cita>(x => x.Estado == estado);
        //}

        public void EliminarCita(string placa)
        {
            _db.Delete<Cita>(x => x.Placa == placa);
        }

        public List<Cita> Mostar()
        {
            //Inicializamos 
            List<DATA.Cita> lista = new List<DATA.Cita>();
            // Creamos patro de fabrica 
            // Pasamos proveedor que esta en el archivo de configuracion para obtener string de conx
            // Variables e Inicializacion
            DbConnection conn = null;
            DbCommand comm = null;

           
            try
            {
                DbProviderFactory factory = DbProviderFactories.GetFactory(BD.Default.proveedor);
                DbParameter param1 = factory.CreateParameter();

                param1.ParameterName = "@iId";
                param1.DbType = System.Data.DbType.Int32;
               /* param1.Value = user.IId;*/


                //Creacion de la connection
                conn = factory.CreateConnection();
                conn.ConnectionString = BD.Default.conexion;
                comm = factory.CreateCommand();

                //Abrir connection
                comm.Connection = conn;
                conn.Open();

                //Ejecuta SP
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_Mostrar";

                using (IDataReader dataReader = comm.ExecuteReader())
                {
                    DATA.Cita cp;
                    while (dataReader.Read())
                    {
                        cp = new DATA.Cita
                        {
                            Cedula = Convert.ToInt32(dataReader["Cedula"].ToString()),
                            Descripmarca = dataReader["Marca"].ToString(),
                            ProVeh = dataReader["ProVeh"].ToString(),
                            FechaIngreso = dataReader["FechaIngreso"].ToString(),
                            Placa = dataReader["iLicencia"].ToString(),
                            Descripestilo = dataReader["Estilo"].ToString(),
                          //  Ano = dataReader["Ano"].ToString(),
                            Nota = dataReader["Nota"].ToString(),
                            Bin = Convert.ToInt32(dataReader["Bin"].ToString()),
                            KM = Convert.ToInt32(dataReader["KM"].ToString()),
                            RevisionIntervalos = dataReader["RevisionIntervalos"].ToString(),
                            MantenimientoPrevio = dataReader["MantenimientoPrevio"].ToString(),
                            DanosVehiculo = dataReader["DanosVehiculo"].ToString()


                        };
                        lista.Add(cp);
                    }
                }

                return lista;
            }
            catch (Exception ee)
            {
                throw;
            }

        }
    }
}

