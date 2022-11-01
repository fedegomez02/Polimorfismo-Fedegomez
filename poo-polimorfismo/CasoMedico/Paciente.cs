using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoMedico
{
    public  class Paciente : Persona
    {
        public Paciente(string nombre, string Id) : base(nombre)
        {
            this.Id = Id;
        }
        public string Id { get; set; }

        public override string ToString()
        {
            return base.ToString() + " "+Id ;
        }
    }
}
