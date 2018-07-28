using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;
using TallerH.BLL.Interfaces;

namespace TallerH.BLL.Metodos
{
    public class MCita : ICita
    {
        DAL.Interfaces.ICita cit;
        public MCita()
        {
            cit = new DAL.Metodos.MCita();
        }
        public void InsertarCita(Cita cita)
        {
            cit.InsertarCita(cita);

        }
        public Cita BuscarCita(string fechaingreso)
        {
            return cit.BuscarCita(fechaingreso);
        }
        public void ActualizarCita(Cita cita)
        {
            cit.ActualizarCita(cita);
        }

        //public void ActualizarCitaestado(string estado)
        //{
        //    cit.ActualizarCitaestado(estado);
        //}

        public void EliminarCita(string placa)
        {
            cit.EliminarCita(placa);
        }
        public List<Cita> ListarCitaDatos()
        {
            return cit.ListarCita();
        }

        public List<Cita> ListarCita()
        {
            return cit.ListarCita();
        }
    }
}