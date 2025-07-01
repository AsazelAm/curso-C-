using System;

namespace cicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bucle FOR
            Console.WriteLine("Aun no he entrando al bucle for");
            for (int i = 0; i <= 10; i +=2) 
            { 
                Console.WriteLine(i);
            }
            Console.WriteLine("Ya sali del bucle For");


            //bucle While
            int a = 1;
            Console.WriteLine("Quiere entrar en el bucle for");
            string confirmacion = Console.ReadLine();

            while ( a <= 10)
            {
                Console.WriteLine(a);
                a++;
            }

            while(confirmacion == "si")
            {
                Console.WriteLine("Estamos dentro del while");
                Console.WriteLine("Quieres estar SIGUE dentro del bucle Whiele");
                confirmacion = Console.ReadLine();
            }

            //Bucle Do While
            string confirmar = "";
            do
            {
                Console.WriteLine("Estamos dentro del bucle while");
                Console.WriteLine("Quieres seguir dentro del bucle");
                confirmar = Console.ReadLine();

            } while (confirmar == "si");
        }


    }
}
