using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public abstract class Animal
    {

        private int _edad;
        private double _altura;
        private double _peso;
        public int edad { get { return _edad; } }
        public double altura { get { return _altura; } }
        public double peso { get { return _peso; } }

        public Animal(int edad, double altura, double peso){
        this._edad = edad;
            this._altura = altura;  
            this._peso = peso;  
        
        }
        public abstract string imprimirComida();
        public virtual string imprimir() { return edad + " " + altura + " " + peso; }
       

    }
}
