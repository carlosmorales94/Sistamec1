using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.BLL.Interfaces
{
    public interface ICliente
    {
        Cliente BuscarCliente(string placa);
        void InsertarCliente(Cliente cliente);
        void ActualizarCliente(Cliente cliente);
        void EliminarCliente(string placa);
        //List<Cliente> ListarCliente();
    }
}
