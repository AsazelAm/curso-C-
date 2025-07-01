using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBuclesArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            int[] numero = numero = new int[10];
            numero[0] = 1;
            numero[1] = 2;
            numero[2] = 3;
            numero[3] = 4;
            numero[4] = 5;
            numero[5] = 6;
            numero[6] = 7;
            numero[7] = 8;
            numero[8] = 9;
            numero[9] = 10;

            for(int i=0; i<numero.Length; i++)
            {
                Console.WriteLine(numero[i]);
            }

            int[] Numero = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int i=0; i<Numero.Length; i++)
            {
                Console.WriteLine(Numero[i]);
            }

            int[] NumeroPares = new int [5];
            int a = 0;
            for(int i=0; i<Numero.Length; i++)
            {
                if (Numero[i] % 2 == 0)
                {
                    NumeroPares[a] = Numero[i];
                    Console.WriteLine($"Los numeros Pares son {NumeroPares[a]}");
                    a= a+1;
                }
            }
            for(int i=0; i<NumeroPares.Length; i++)
            {
                Console.WriteLine(NumeroPares[i]);
            }
            //eJERCICIO 2
            string[] Semanas = new[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            Console.WriteLine("Introdusca el dia libre de la Semana del 1 al 7");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Su dia libre de la semana es {Semanas[dia -1]}");

            //EJERCICIO 3
            Console.WriteLine("Introduce el tamaño de los clientes");
            int NroClientes = int.Parse(Console.ReadLine());
            string[] Clientes = new string[NroClientes];
            int[] edad = new int[NroClientes];
            string clientes;
            for(int i=0; i<Clientes.Length; i++)
            {
                Console.WriteLine("Introduce el nombre del Cliente");
                clientes = Console.ReadLine();
                Clientes[i] = clientes;

                Console.WriteLine($"Introduce la edad de {Clientes[i]}");
                edad[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("Lista de los Clientes");
            for(int i=0; i<Clientes.Length; i++)
            {
                Console.WriteLine($"{i+1} Nombre:{Clientes[i]}      Edad:{edad[i]}");
            }


        }
    }
}
