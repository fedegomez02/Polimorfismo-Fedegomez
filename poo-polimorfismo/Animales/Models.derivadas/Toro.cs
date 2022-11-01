using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales.Models.derivadas
{
    public class Toro: Animal
    {

        public string colorCuerno;

        public Toro(int edad, double altura, double peso, string color) : base(edad, altura, peso)
        {
            this.colorCuerno = color;
        }

        public override string imprimirComida()
        {
            return "come pasto";
        }

        public override string imprimir()
        {
            return base.imprimir() + colorCuerno;
        }
    }
}
