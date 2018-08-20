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
    public class MContra : IContra
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MContra()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void InsertarPrope(ProdContra prodContra)
        {
            _db.Insert(prodContra);
        }
        public void EliminarPrope(string Producto)
        {
            _db.Delete<ProdContra>(x => x.Producto == Producto);
        }
        public List<ProdContra> ListarPrope()
        {
            return _db.Select<ProdContra>();
        }
    }
}
