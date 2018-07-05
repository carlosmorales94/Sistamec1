using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.DAL.Interfaces
{
    public interface ICita
    {
        List<Cita> ListarCita();
        //void ActualizarCitas(Citas citas);
        Cita BuscarCita(string placa);
        void InsertarCita(Cita cita);
        void EliminarCita(string placa);
    }
}