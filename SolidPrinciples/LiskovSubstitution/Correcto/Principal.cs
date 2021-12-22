using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.Correcto
{
    public class Principal
    {
        public static void main(string[] args)
        {
            Coche[] arrayCoches = {
                new Renault(),
                new Audi(),
                new Mercedes(),
            };
            imprimirPrecioMedioCoche(arrayCoches);
            imprimirNumAsientos(arrayCoches);
        }

        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                Console.WriteLine(coche.precioMedioCoche());
            }
        }

        public static void imprimirNumAsientos(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                Console.WriteLine(coche.numAsientos());
            }
        }
    }
}
