﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerH.DATA;

namespace TallerH.BLL.Interfaces
{
    public interface ICita
    {
        void Actualizar(Cita cita);
        List<Cita> ListarCita(string fechaingreso);
        //List<Cita> ListarCitaDatos();
        void ActualizarCita(Cita cita);
       // void ActualizarCitaestado(string estado);
        Cita BuscarCita(string fechaingreso);
        void InsertarCita(Cita cita);
        void EliminarCita(string placa);
        List<Cita> Mostar();
    }
}
