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
   public class MFacturass : IFacturass
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MFacturass()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
       

        public void InsertarFactura(Facturass fact)
        {
            _db.Insert(fact);
        }
    }
}
