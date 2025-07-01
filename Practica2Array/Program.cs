using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //ElementMAYORyPosicion
            Console.WriteLine("Ingrese el tamaño del Vector");
            int TamV = int.Parse(Console.ReadLine());
            int[] Array = new int[TamV];

            Cargar(Array);
            Mostrar(Array);
            int ElemMayor = ElementoMayor(Array);
            int Pos = PosicionElemento(Array);

            Console.WriteLine("El elemento Mayor es " + ElemMayor);
            Console.WriteLine("La Posicion del elemento Mayor es:{0}", Pos);
        }

        public static void Cargar(int[] Vector)
        {
            for(int i=0; i<Vector.Length; i++)
            {
                Console.Write("Ingrese los datos en el vector en la Posicion [{0}] = ",i);

                Vector[i] = Convert.ToInt32(Console.ReadLine());

            }
        }

        public static void Mostrar(int[] Array)
        {
            Console.WriteLine();
            Console.WriteLine("Datos del Array");
            for(int i=0; i<Array.Length; i++)
            {
                Console.WriteLine($"Array [{i}] = {Array[i]}");
            }
        }

        public static int ElementoMayor(int[] Vector)
        {
            int Mayor= Vector[0];
            for(int i=0; i<Vector.Length; i++)
            {
                if (Vector[i] > Mayor)
                {
                    Mayor = Vector[i];//Almacena al Mayor
                }
            }
            return Mayor;
        }

        public static int PosicionElemento(int[] Array)
        {
            int pos =0;
            int Mayor = Array[0];
            for(int i=0; i<Array.Length; i++)
            {
                if (Array[i]> Mayor)
                {
                    Mayor = Array[i];
                    pos = i;
                }
            }
            return pos;
        }
    }
}
