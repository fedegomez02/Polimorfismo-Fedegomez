﻿using LibAjedrez.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez.Models.Derivadas
{
    public class Torre : PiezaAjedrez
    {
        public override string mover()
        {
            return "se mueve 8 espacios en vertical ";
        }
    }
}
