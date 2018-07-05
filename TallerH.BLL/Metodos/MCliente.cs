using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;

namespace TallerH.BLL.Metodos
{
    
    public class MCliente : ICliente
    {
        DAL.Interfaces.ICliente cli;
        public MCliente()
        {
            cli = new DAL.Metodos.MCliente();
        }
        public void InsertarCliente(Cliente cliente )
        {
            cli.InsertarCliente(cliente);
        }
        public Cliente BuscarCliente(string placa)
        {
            return cli.BuscarCliente(placa);
        }
        public void ActualizarCliente(Cliente cliente)
        {
            cli.ActualizarCliente(cliente);
        }
        public void EliminarCliente(string placa)
        {
            cli.EliminarCliente(placa);
        }
        //public List<Cliente> ListarCliente()
        //{
        //    return cli.ListarCliente();
        //}
    }
}
