using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Paciente : PersonaClinica
    {
        public int NroHistoriaClinica { get; set; }
        public Paciente(int Id, string Nombre, string Apellido, string direccion, string Telefono, string Email, int NroHistoriaClinica) : base(Id, Nombre, Apellido, direccion, Telefono, Email)
        {
            this.NroHistoriaClinica = NroHistoriaClinica;
        }

        public Paciente() { }

    }
}
