using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoArray4
{
    internal class NumerosReales
    {
        public void Principal()
        {
            Console.WriteLine("Entreee");
            float[] Array = new float[5] { 1.2F, 3.2F, 32.3F, 4.3F, 43.4F };//Se coloca el sufijo F si es float
            for(int i=Array.Length -1;i>=0; i--)// le asignamos el tamaño del array y lo restamos -1
            {
                Console.WriteLine(Array[i]);
            }
            Console.ReadKey();
        }
    }
}
