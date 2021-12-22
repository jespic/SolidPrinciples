using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClose.Correcto
{
    public abstract class Coche
    {
        public String Marca { get; set; }
        public abstract int precioMedioCoche();

    }
}
