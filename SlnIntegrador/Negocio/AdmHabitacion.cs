﻿using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
     public class AdmHabitacion
    {
        List<Habitacion> habitaciones;
        public List<Habitacion> Listar()
        {
            habitaciones = new List<Habitacion>();
            habitaciones.Add(new Habitacion() {Id = 323, Estado ="limpio", numero= 34 });
            habitaciones.Add(new Habitacion() { Id =444, Estado = "a limpiar", numero = 33 });
            habitaciones.Add(new Habitacion() { Id = 878, Estado = "a ordenar", numero = 32 });
            return habitaciones;

        }
        public List<Habitacion> Listar(string estado)
        {

            List<Habitacion> habitacionesEstado = new List<Habitacion>();  
            foreach (Habitacion habitacion in habitaciones)
            {
                if (habitacion.Estado == estado)
                {
                    habitacionesEstado.Add(habitacion);
                }
            }
            return habitacionesEstado;
        }

        public int Insertar(Medico medico)
        {
            return 0;
        }

        public int Eliminar(int id)
        {
            return 0;
        }

        public Medico TraerUno(int id)
        {
            return null;
        }




    }
}
