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
    public class MEstilos : IEstilos
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MEstilos()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void InsertarEstilo(Estilos estilo)
        {
            _db.Insert(estilo);
        }
        public void EliminarEstilo(string descripestilo)
        {
            _db.Delete<Estilos>(x => x.Descripestilo == descripestilo);
        }
        public List<Estilos> ListarEstilo()
        {
            return _db.Select<Estilos>();
        }
    }
}
