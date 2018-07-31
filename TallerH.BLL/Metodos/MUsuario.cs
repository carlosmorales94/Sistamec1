using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;
using System.Data.Common;
using System.Transactions;
using TallerH.DAL;
namespace TallerH.BLL.Metodos
{
    public class MUsuario : IUsuario
    {
        private static MUsuario instancia;

        public static MUsuario Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return new MUsuario();
                }
                return instancia;

            }
            set
            {
                if (instancia == null)
                {
                    instancia = value;
                }
            }
        }


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



        public void Insertar(DATA.Usuario usuario)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Metodos.MUsuario.Instancia.InsertarUsuario(usuario);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }



    }
}
