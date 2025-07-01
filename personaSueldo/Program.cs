using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personaSueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado("Guillermo", "Mamami",3000);
            empleado1.mostrarDato();
            Empleado empleado2 = new Empleado("jose", "Choquehuanca", 4000);
            empleado2.mostrarDato();
            Empleado empleado3 = new Empleado("Miguel", "Ronaldo", 5000);
            empleado3.mostrarDato();

            Console.ReadKey();
        }
    }
}
