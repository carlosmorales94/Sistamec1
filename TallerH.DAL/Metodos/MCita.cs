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
    public class MCita : ICita
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MCita()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public List<Cita> ListarCita()
        {
            return _db.Select<Cita>();
        }

        public void InsertarCita(Cita cita)
        {
            _db.Insert(cita);
        }
        public Cita BuscarCita(string placa)
        {
            return _db.Select<Cita>(x => x.Placa == placa).FirstOrDefault();
        }
        //public void ActualizarCitas(Citas citas)
        //{
        //    _db.Update(citas);
        //}

        public void EliminarCita(string placa)
        {
            _db.Delete<Cita>(x => x.Placa == placa);
        }
    }
}

