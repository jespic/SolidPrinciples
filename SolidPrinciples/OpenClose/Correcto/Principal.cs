using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClose.Correcto
{
    public class Principal
    {
        public static void main(String[] args)
        {

            Coche[] arrayCoches = {
            new Renault(),
            new Audi(),
            new Mercedes()
    };

            imprimirPrecioMedioCoche(arrayCoches);
        }

        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                Console.Out.WriteLine(coche.precioMedioCoche());
            }
        }
    }
}
