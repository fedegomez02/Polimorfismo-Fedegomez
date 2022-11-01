using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales.Models.derivadas
{
    public class Conejo : Animal
    {

        public int saltoMaximo;
        public Conejo(int edad, double altura, double peso, int saltoMaximo) : base(edad, altura, peso)
        {
            this.saltoMaximo = saltoMaximo;
        }

        public override string imprimirComida()
        {
            return "come verdura";
        }

        public override string imprimir()
        {
            return base.imprimir() +saltoMaximo;
        }
    }
}
