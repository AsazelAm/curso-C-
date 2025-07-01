using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array Cargar Mostrar
            int[] Array = new int[5];
            int suma, sumPar;
            double Promedio;
            Cargar(Array);
            Mostrar(Array);
            suma = Sumar(Array);
            sumPar = SumarPares(Array);
            Promedio = PromedioTodos(Array);

            Console.WriteLine("La suma de los elementos {0}",suma);
            Console.WriteLine("La suma de los Pares " + sumPar);
            Console.WriteLine($"El promedio de los Elementos {Promedio}");

        }

        public static void Cargar(int[] Array)
        {
            Console.WriteLine("Ingrese los datos del Array");
            for(int i=0; i<Array.Length; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void Mostrar(int[] Array)
        {
            for(int i=0; i<Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }

        public static int Sumar(int[] Array)
        {
            int sumaTo=0;
            for(int i=0; i<Array.Length; i++)
            {
                sumaTo = sumaTo + Array[i];
            }
            return sumaTo;
        }
        public static int SumarPares(int[] Array)
        {
            int sumPa = 0;
            for(int i=0; i<Array.Length; i++)
            {
                if (Array[i] % 2 == 0)
                {
                    sumPa = sumPa + Array[i];
                }
            }
            return sumPa;
        }
        public static double PromedioTodos(int[] Array)
        {
            double Prome=0;
            int sum =0;
            int Conteo = 0;
            for(int i=0; i<Array.Length; i++)
            {
                sum = sum + Array[i];
                Conteo = i + 1;
                Prome =(double) sum / Conteo;//Hace el cast para q me salga con decimal
            }
            return Prome;
        }
    }
}
