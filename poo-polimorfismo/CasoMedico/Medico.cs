using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CasoMedico
{
    public class Medico : Persona
    {
        public Medico(string nombre, string especialidad) : base(nombre)
        {
            this.especialidad = especialidad;
        }
        public string especialidad;
        public override string ToString()
        {
            return base.ToString() + " "+ especialidad;
        }

    }
}
