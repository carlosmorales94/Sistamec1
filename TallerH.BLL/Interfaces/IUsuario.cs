using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.BLL.Interfaces
{
    public interface IUsuario
    {
        Usuario BuscarUsuario(string username, string password);
        void InsertarUsuario(Usuario usuario);

        //Usuario BuscarFactura(string username, string password);
        //void InsertarFactura(Usuario usuario);
        //Usuario BuscarUsuario(string username, string password);
        //void InsertarUsuario(Usuario usuario);
        //Usuario BuscarUsuario(string username, string password);
        //void InsertarUsuario(Usuario usuario);
        //Usuario BuscarUsuario(string username, string password);
        //void InsertarUsuario(Usuario usuario);
        //Usuario BuscarUsuario(string username, string password);
        //void InsertarUsuario(Usuario usuario);
    }
}
