using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsability.Correcto
{
    //Cada clase debe tener una única responsabilidad
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
    }
}
