using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DAL.Interfaces;
using TallerH.DATA;
using System.Data;
using ServiceStack.OrmLite;


namespace TallerH.DAL.Metodos
{
    public class MUsuario : IUsuario
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MUsuario()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public Usuario BuscarUsuario(string usuario, string contra)
        {
            return _db.Select<Usuario>(x => x.Username == usuario && x.Password == contra).FirstOrDefault();
        }
        public void InsertarUsuario(DATA.Usuario usuario)
        {
            _db.Insert(usuario);
        }
    }
}
