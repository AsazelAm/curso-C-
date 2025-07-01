using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PARAMETROS son variables que nosotros utilizamos para mostrar informacion desde el metodo main 
            Console.WriteLine("Estamos enel metodo main");
            MostrarMensaje(); //lo llamos al methodo
            Console.WriteLine("Ya se ha ejecutado nuestro metodo mostrarMensaje");
            int suma=Suma();//haca llamamos al metodo y el valor que va a retornar lo almacenamos en una variable para ocupar el valor
            Console.WriteLine(suma);
            Console.WriteLine(Suma());//otra forma de llamar el metodo y mostar lo q va a retornar

            // Parametros
            int numero1 = 10;
            int numero2 = 15;
            Console.WriteLine("la suma de {0} + {1} = {2}",numero1, numero2, Sumarr(numero1,numero2));
            int resultado=Sumarr(numero1,numero2);
            Console.WriteLine(resultado);

            //con parametro void
            string mensaje = "este el mensaje del void";
            Mensaje(mensaje);
        }
        //ES un bloque de codigo que contiene en su interior una serie de instrucciones a este bloq de codigo
        //se le da el nombre y gracias a ese nombre podemos utilizarlo en cualquier parte del programa simplemente escribiendo el nombre mismo
        //a esto se llama llamar un metodo
        //los metodos pueden de volver o no un valor
        //void= quiere decir que el method no devolvera nada solo se ejecutara cuando este sea llamado

        //public= es un modificador de aceso 
        public static void MostrarMensaje()//esto es la sintaxis de crear un metodo
                                           //le colocamos la palabra static solo por el hecho q estamos dentro de la  class Program
        {
            Console.WriteLine("Este es nuestro primer metodo");
        }
        //metodo que devuelve el valor 
        // se declara con el tipo de dato y se devuelve un valor con return
        public static int Suma()
        {
            int suma = 5 + 10;
            return suma;
        }

        //metodo con parametro
        /*los argumentos que se lke pasa desde el programa principal no nesesariamente tiene que ser el mismo nombre
         */
        public static int Sumarr(int num1, int num2)//sintaxis los parametros se coloca el tipo de dato
        {
            int suma = num1 + num2;
            return suma;
        }

        public static void Mensaje(string mens)
        {
            Console.WriteLine(mens);
        }
    }
}
