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
    public class MAuto : IAuto
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MAuto()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public List<Auto> ListarAutos()
        {
            return _db.Select<Auto>();
        }

        public void InsertarAuto(Auto auto)
        {
            _db.Insert(auto);
        }
        public Auto BuscarAuto(string placa)
        {
            return _db.Select<Auto>(x => x.Placa == placa).FirstOrDefault();
        }
        public void ActualizarAuto(Auto auto)
        {
            _db.Update(auto);
        }

        public void EliminarAuto(string placa)
        {
            _db.Delete<Auto>(x => x.Placa == placa);
        }
    }
}
