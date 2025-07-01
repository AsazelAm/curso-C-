using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoArray4
{
    class PracticoArray5
    {
        public void practicoArray()
        {
            int tam;
            Console.WriteLine("Ingrese el tamaño del Array");
            tam = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[tam];
            cargar(Array);
            Mostra(Array);
            Posicion(Array,tam);
        }
        public void cargar(int[] Array)
        {
            Console.WriteLine("Ingrese los datos del array");
            for(int i=0;i<Array.Length; i++)
            {
                Console.Write("Vector [{0}] = ", i);
                Array[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Mostra(int[] Array)
        {
            Console.WriteLine();
            for(int i=0; i<Array.Length; i++)
            {
                Console.WriteLine("Vector [" + i + "] = " + Array[i]);
            }
        }
        public void Posicion(int[] Array,int tam)
        {
            int el, pos=0, mit;
            Console.WriteLine("Ingrese el elementos a Buscar");
            el = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<Array.Length; i++)
            {
                if (Array[i] == el)
                {
                    pos = i;
                }

            }
            if(tam % 2 == 0)
            {
                mit = tam / 2;
                Console.WriteLine(mit);
                Console.WriteLine(pos);
                if (pos < mit - 1)//para pares
                {
                    Console.WriteLine("El elementos se encuentra ANTES de la mitad");
                }
                else
                    if (pos == mit - 1)
                {
                    Console.WriteLine("El elemento se encuentra en la MITAD");
                }
                else
                {
                    Console.WriteLine("El elemento se encuentra DESPUES de la Mitad");
                }
            }
            else
            {
                mit = tam / 2;
                Console.WriteLine(mit);
                Console.WriteLine(pos);
                if (pos < mit )//para impares
                {
                    Console.WriteLine("El elementos se encuentra ANTES de la mitad");
                }
                else
                    if (pos == mit )
                {
                    Console.WriteLine("El elemento se encuentra en la MITAD");
                }
                else
                {
                    Console.WriteLine("El elemento se encuentra DESPUES de la Mitad");
                }
            }
            
        }
    }
}
