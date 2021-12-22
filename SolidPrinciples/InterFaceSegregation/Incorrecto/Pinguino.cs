using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterFaceSegregation.Incorrecto
{
    public class Pinguino : IAve
    {
        public void volar()
        {
            //...
        }

        public void comer()
        {
            //..
        }
        public void nadar()
        {
            //..
        }
    }
}
