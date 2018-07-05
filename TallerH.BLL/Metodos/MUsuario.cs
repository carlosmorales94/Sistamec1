using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;

namespace TallerH.BLL.Metodos
{
    public class MUsuario : IUsuario
    {
        DAL.Interfaces.IUsuario usu;
        public MUsuario()
        {
            usu = new DAL.Metodos.MUsuario();
        }

        public Usuario BuscarUsuario(string username, string password)
        {
            return usu.BuscarUsuario(username, password);
        }
        public void InsertarUsuario(Usuario usuario)
        {
            usu.InsertarUsuario(usuario);
        }
    }
}
