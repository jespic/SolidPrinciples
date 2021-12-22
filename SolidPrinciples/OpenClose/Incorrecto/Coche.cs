using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClose.Incorrecto
{
    public class Coche
    {
        public Coche(string marca)
        {
            Marca = marca;
        }

        public String Marca { get; set; }

    }
}
