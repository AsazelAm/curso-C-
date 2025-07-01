using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Modificador STATIC
            /* El modificador static nos permite acceder a atributos o metodos de una clase sin instanciar un objeto de esa clase
               lo que hacemos normalmente estamos creando variables y metodos de Instancia 
            solo se ocupa para atributos que todas la instancia van a tener el mismo valor*/
            VehiculoTransporte van1 = new VehiculoTransporte("Van", "Negro", "AC4WWS");
            VehiculoTransporte autobus1 = new VehiculoTransporte("Autobus", "Azul", "S24IM0");
            VehiculoTransporte autobus2 = new VehiculoTransporte("Autobus", "Blanco", "14QMFD");

            //Para accder al valor de la variable static se llama la clase y la variable static
            Console.WriteLine("Estoy mostrando el valor de mi variable static {0}", VehiculoTransporte.tarifa);
            //van1.MostrarTarifa();
            VehiculoTransporte.AumentoTarifa();
            Console.WriteLine("Estoy mostrando el valor de mi variable static {0}", VehiculoTransporte.tarifa);

            //Dato curioso
            /* Console.WriteLine= WriteLine es un metodo statico
             * Console = es una clase
             * const = en C# todas las constantes son consideradas como estaticas porq una constante es algo a nivel global es un valor q no 
             * debe ser cambiado
             * Igual se puede tener clases staticas las clases staticas no puede ser instanciada
             * ejemplo Math matematicas = new Math();
             */


        }
    }
}
