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
    public class MCliente : ICliente
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MCliente()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public Cliente BuscarCliente(string placa)
        {
            return _db.Select<Cliente>(x => x.Placa == placa).FirstOrDefault();
        }

        public void InsertarCliente(Cliente cliente )
        {
            _db.Insert(cliente);
        }

        public void ActualizarCliente(Cliente cliente)
        {
            _db.Update(cliente);
        }

        public void EliminarCliente(string placa)
        {
            _db.Delete<Cliente>(x => x.Placa == placa);
        }
    }
}
