using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales.Models.derivadas
{
    public class Leon : Animal
    {
        public string DiametroUñas;
        public Leon(int edad, double altura, double peso,string diametro ) : base(edad, altura, peso)
        {
            this.DiametroUñas = diametro;
        }

        public override string imprimirComida()
        {
            return "come carne";
        }
        public override string imprimir()
        {
            return base.imprimir() + " "+ DiametroUñas;
        }
    }
}
