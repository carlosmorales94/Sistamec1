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
        //List<Cita> ListarCita();
        List<Cita> ListarCita(DateTime fechaingreso);
        List<Cita> ListarCitaDatos();
        void ActualizarCita(Cita cita);
     //   void ActualizarCitaestado(string estado);
        Cita BuscarCita(DateTime fechaingreso);
        void InsertarCita(Cita cita);
        void EliminarCita(string placa);
        List<Cita> Mostar();
    }
}