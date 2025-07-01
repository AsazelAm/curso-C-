using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoArray4
{
    class PracticoArray3
    {
        //Indique si los elementos son Mayores a 100
        public void PracticoArray()
        {
            int[] Vector = new[] {23,102,43,89,203,200,130,35,53};
            Mostrar(Vector);
            int May = ElementosMayores(Vector);
            int Men = ElementosMenores(Vector);

            Console.WriteLine("Elementos Mayores {0}", May);
            Console.WriteLine($"Elementos Menores {Men}");
        }
        public void Mostrar(int[] Vector)
        {
            Console.WriteLine("Datos del Vector");
            for(int i=0; i<Vector.Length; i++)
            {
                Console.WriteLine("Vector  [" + i + "] = " + Vector[i]);
            }
        }

        public int ElementosMayores(int[] Vector)
        {
            int conMa = 0;
            for(int i=0; i<Vector.Length; i++)
            {
                if (Vector[i] > 100)
                {
                    conMa = conMa + 1;
                }
            }
            return conMa;
        }
        public int ElementosMenores(int[] Vector)
        {
            int conMe = 0;
            for(int i=0; i<Vector.Length; i++)
            {
                if (Vector[i] < 100)
                {
                    conMe = conMe + 1;
                }
            }
            return conMe;
        }



    }
}
