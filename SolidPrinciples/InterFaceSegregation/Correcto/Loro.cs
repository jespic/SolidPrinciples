﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterFaceSegregation.Correcto
{
    public class Loro : IAve, IAveVoladora
    {
        public void volar()
        {
            //...
        }

        public void comer()
        {
            //..
        }
    }
}
