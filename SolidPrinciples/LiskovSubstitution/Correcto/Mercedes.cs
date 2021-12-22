﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.Correcto
{
    public class Mercedes : Coche
    {
        public override int precioMedioCoche()
        {
            return 27000;
        }

        public override int numAsientos()
        {
            return 6;
        }
    }
}
