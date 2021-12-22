using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.Correcto
{
    public class Renault : Coche
    {
        public override int precioMedioCoche()
        {
            return 21000;
        }

        public override int numAsientos()
        {
            return 4;
        }
    }
}
