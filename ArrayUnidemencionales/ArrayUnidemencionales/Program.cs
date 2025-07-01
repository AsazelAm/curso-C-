using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUnidemencionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //los arrays nos permite almacenar muchos datos del mismo tipo de dato
            int[] arrayEnteros;//creamos el array
            arrayEnteros = new int[5];//Inicializamos un arry de 5 elementos
            //si no le asiganamos un valor al array por defecto por q es de tipo int todos los valores sera 0 

            //Con la palabre new int[] podemos reservar espacio con la orden "new"

            //otra forma de crear e inicializarlo de forma mas directa
            //int[] arrayEnteros = arrayEnteros = new int[5]

            //las posiciones enpiezan desde 0
            /*Lo q estamos haciendo le estamos agregando el valor 5 al elemento uno en la posicion o indice 0 
             RELLENAMOS EL ARRAY*/
            arrayEnteros[0] = 5;
            arrayEnteros[1] = 10;
            arrayEnteros[2] = 8;
            arrayEnteros[3] = 4;
            arrayEnteros[4] = 25;


            Console.WriteLine(arrayEnteros[4]);//parra mostra el valor del elemento del array en su posicion

            //otra forma de rellenar un array
            //hay que declararlo e inicializarlo, en las llaves colocamo los valores que va tener separados por comas en el array
            string[] nombres = { "Carlos", "Mariana", "Jose", "luis" };
            //            string[] nombres = new[] { "Carlos", "Mariana", "Jose", "luis" }; igual se puede haci
            Console.WriteLine(nombres[3]);
            //si colocamos una posicion q no existe nos va dar un Erros una Exepction

            for(int i=0; i < 5; i++)
            {
                //mostramos a todo los elementos del array colocamos i para que señale su posicion del elemento y se muestre el valor
                Console.WriteLine(arrayEnteros[i]);
            }

            //otra forma de rellenar
            int[] ArrayEntero = ArrayEntero = new int[1000];
            //el metodo .length obtiene el numero total de los elementos de todas las dimensiones del array

            //Console.WriteLine(ArrayEntero.Length); MUESETRA LA CANTIDAD DE ELEMENTOS QUE TIENE EL ARRAY
            /*for (int i= 0; i<ArrayEntero.Length; i++)
            {
                ArrayEntero[i] = i+1;
                Console.WriteLine(ArrayEntero[i]);//mostramos los elementos del array

            }*/

            //mostrar el array
            /*for(int i= 0; i<1000; i++)
            {
                Console.WriteLine(ArrayEntero[i]);
            }*/

            //EJEMPLO DE ARRAY
            double[] arrayMedia = new double[5];
            RellenarArray(arrayMedia);//pasamos el array por parametro

            Console.WriteLine("la media de las notas es {0}",CalcularMedia(arrayMedia));

            //mostramos el array
            for(int i= 0; i< arrayMedia.Length; i++)
            {
                Console.WriteLine(arrayMedia[i]);
            }
        }

        static void RellenarArray(double[] array)//no importa el nombre se declara el tipo [] y nombreArray
        {
            int i = 0;
            do
            {
                Console.WriteLine("Introduce la nota {0}", i+1);//i + 1 para que muestre desde el numero 1
                double numeroMedia = double.Parse(Console.ReadLine());

                //accedemos a la posicion 0 del array y le agregamo el valor que intr0ducio el usuario
                array[i] = numeroMedia;
                i++;
            } while (i < array.Length);
        }

        static double CalcularMedia(double[] array)
        {
            double mediaTotal = 0;
            for(int i=0; i<array.Length; i++)
            {
                //recoremos el array
                mediaTotal = mediaTotal + array[i];//simplificado mediaTotal+=array[i]

            }
            mediaTotal/= array.Length;//array.Length para q me muestre el tamaño total del array
            return mediaTotal;
        }
    }
}
