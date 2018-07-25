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
    public class MEstilo : IEstilo
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MEstilo()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void EliminarEstilos(string descripcionestilo)
        {
            _db.Delete<Estilo>(x => x.DescripcionEstilo == descripcionestilo);
        }

        public void InsertarEstilos(Estilo estilo)
        {
            _db.Insert(estilo);
        }

        public List<Estilo> ListarEstilos()
        {
            return _db.Select<Estilo>();
        }
    }
}
