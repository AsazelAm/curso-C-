using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoArray3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indiq si todos los elementos son Mayores
            Console.WriteLine("Ingrese el tamaño del Array");
            int Tam = Convert.ToInt32(Console.ReadLine());
            int[] Vector = new int[Tam];
            Cargar(Vector);
            Mostrar(Vector);
            Iguales(Vector);
        }
        public static void Cargar (int[] Vector)
        {
            Console.WriteLine("Ingrese los datos del Vector");
            for(int i=0; i<Vector.Length; i++)
            {
                Console.Write($"Vector [{i}] = ");
                Vector[i] = int.Parse(Console.ReadLine());

            }
        }
        public static void Mostrar(int[] Vector)
        {
            Console.WriteLine();
            Console.WriteLine("El vector");
            for(int i=0; i<Vector.Length; i++)
            {
                Console.WriteLine("Vector [{0}] = {1}",i,
                    Vector[i]);
            }
        }
        public static void Iguales(int[] Vector)
        {
            int Compa = Vector[0];
            bool verdadero = true;
            for(int i=0; i<Vector.Length; i++)
            {
                switch(Vector[i] == Compa) 
                {
                    case true:
                        break;
                    default:
                        verdadero = false;
                        break;
                }
            }

            if (verdadero == true)
            {
                Console.WriteLine("Todos los elementos son IGUALES");
            }
            else
            {
                Console.WriteLine("NO SON IGUALES");
            }
        }
    }
}
