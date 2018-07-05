using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.DAL.Interfaces
{
    public interface IUsuario
    {
        DATA.Usuario BuscarUsuario(string usuario, string contra);
        void InsertarUsuario(DATA.Usuario usuario);
    }
}
