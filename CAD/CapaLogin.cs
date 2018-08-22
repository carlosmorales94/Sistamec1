using CAD.DataSet2TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class CapaLogin
    {

        private static UsuarioTableAdapter adap = new UsuarioTableAdapter();

        public static bool ExisteUsuario(string Username, string Password)
        {
            if (adap.ExisteUsuario(Username, Password) == null)
            {

                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
