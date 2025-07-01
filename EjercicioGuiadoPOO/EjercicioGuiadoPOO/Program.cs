using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuiadoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lo primero q haremos vamos a crear la clase triangulo en un modulo aparte
            Triangulo equilatero = new Triangulo(5);

            double bas =0;
            do
            {
                Console.WriteLine("Introduce la base del triangulo isoceles");
                bas = double.Parse(Console.ReadLine());
            } while (bas == 0);

            Triangulo isoceles = new Triangulo(5, bas);


            Console.WriteLine("El perimetro de mi triangulo Equilatero es {0}",equilatero.CalcularPerimetro());
            Console.WriteLine("El perimetro del triangulo Isoceles es {0} ",isoceles.CalcularPerimetro());

            equilatero.CalcularAltura();
            isoceles.CalcularAltura();

            if(equilatero.GetAltura() > 0) Console.WriteLine("El area de  mi triangulo Equilatero es {0}", equilatero.CalcularArea());

            if (isoceles.GetAltura() > 0) Console.WriteLine("El area de mi triangulo Isoceles es {0}", isoceles.CalcularArea());
            else Console.WriteLine("No hay base " + bas);
        }
    }
}
