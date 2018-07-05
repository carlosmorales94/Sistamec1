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
        public Cita BuscarCita(string placa)
        {
            return cit.BuscarCita(placa);
        }
        //public void Actualizarcitas(Citas citas)
        //{
        //    cit.ActualizarAuto(citas);
        //}

        public void EliminarCita(string placa)
        {
            cit.EliminarCita(placa);
        }
        public List<Cita> ListarCita()
        {
            return cit.ListarCita();
        }
    }
}