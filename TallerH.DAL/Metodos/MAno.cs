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
    public class MAno : IAno
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MAno()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void InsertarAno(Ano ano)
        {
            _db.Insert(ano);
        }
        public void EliminarAno(int descripano)
        {
            _db.Delete<Ano>(x => x.Descripano == descripano);
        }
        public List<Ano> ListarAno()
        {
            return _db.Select<Ano>();
        }
    }
}
