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
    public class MModelo : IModelo
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MModelo()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void EliminarModelos(string descripcionmodelo)
        {
            _db.Delete<Modelo>(x => x.DescripcionModelo == descripcionmodelo);
        }

        public void InsertarModelos(Modelo modelo)
        {
            _db.Insert(modelo);
        }

        public List<Modelo> ListarModelos()
        {
            return _db.Select<Modelo>();
        }
    }
}
