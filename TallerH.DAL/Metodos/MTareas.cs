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
    public class MTareas : ITareas
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MTareas()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void InsertarTareas(Tareas tareas)
        {
            _db.Insert(tareas);
        }
        public void EliminarTareas(string descripciontask)
        {
            _db.Delete<Tareas>(x => x.Descripciontask == descripciontask);
        }
        public List<Tareas> ListarTareas()
        {
            return _db.Select<Tareas>();
        }
    }
}
