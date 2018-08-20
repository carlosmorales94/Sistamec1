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
    public class MServicios : IServicios
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MServicios()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void InsertarServicio(Servicios servicios)
        {
            _db.Insert(servicios);
        }
        public void EliminarServicio(string Servicio)
        {
            _db.Delete<Servicios>(x => x.Servicio == Servicio);
        }
        public List<Servicios> ListarServicio()
        {
            return _db.Select<Servicios>();
        }
    }
}
