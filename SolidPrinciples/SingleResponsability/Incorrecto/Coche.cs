using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsability.Incorrecto
{
    class Coche
    {
        String marca;

        Coche(string marca)
        {
            this.marca = marca;
        }
        string getMarcaCoche()
        {
            return marca;
        }

        void guardarCocheDB(Coche coche)
        {
            
        }
    }
}
