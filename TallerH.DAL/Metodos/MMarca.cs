﻿using System;
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
    public class MMarca : IMarca
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MMarca()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void InsertarMarca(Marca marca)
        {
            _db.Insert(marca);
        }
        public void EliminarMarca(string descripmarca)
        {
            _db.Delete<Marca>(x => x.Descripmarca == descripmarca);
        }
        public List<Marca> ListarMarca()
        {
            return _db.Select<Marca>();
        }
    }
}
