using polimorfismo.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo.Models.Derivadas
{
    public class Piano : InstrumentoMusical
    {
        public override string afinar()
        {
            return "afinando el piano";
        }
    }
}
