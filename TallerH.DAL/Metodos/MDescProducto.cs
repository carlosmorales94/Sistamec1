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
    public class MDescProducto : IDescProducto
        {
            private OrmLiteConnectionFactory _conexion;
            private IDbConnection _db;
            public MDescProducto()
            {
                _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                    SqlServerDialect.Provider);
                _db = _conexion.Open();
            } 

            public void InsertarDescProducto(DescProducto descProducto)
            {
                _db.Insert(descProducto);
            }
            public DescProducto BuscarDescProducto(string placa )
            {
                return _db.Select<DescProducto>(x => x.Placa == placa).FirstOrDefault();
            }
        }
    }

