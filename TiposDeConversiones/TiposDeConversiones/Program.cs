using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeConversiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero= 50;
            double numeroDecimal = numero; // es una conversion inplicita el compilador se encargara de la conversion 
            //de acuerdo a algunas reglas de la tabla de conversion numerica
            //el cambio se realiza de un tipo de dato de bits si es in t es de 32bits a long es de 64bits

            /*double numeroDecimall;// no me deja cambiar de forma inplicita no medja cambiar de un numero mayor de bits a una menor de bits
            int number = numeroDecimall;*/

            //Convversiones Explicitas
            long numeroGrande = 2034L; //se coloca el sufijo L
            int numerooo = (int)numeroGrande;//la sintaxis para cambiarlo en conversion explicita
            Console.WriteLine(numerooo);

            Console.WriteLine("Ingresa tu nombre");
            string nombre = Console.ReadLine();//este methodo devuelve un string

            Console.WriteLine("Escribe tu edad");
            int edad = int.Parse(Console.ReadLine());//es un methodo para cambiar la cadena de texto numerico a un numero de tipo entero
            //pero no permite de con letrar o de tipo float

            //CONDICIONAL ELSE IF IF ANIDADO
            double gradoCorporal = 36;
            if( gradoCorporal <= 35)
            {
                Console.WriteLine("hipotermia");
            }else if(gradoCorporal <= 36 && gradoCorporal<= 37.5)
            {
                Console.WriteLine("Normal");
            }else if( gradoCorporal > 37.5 && gradoCorporal <= 39.5)
            {
                Console.WriteLine("fiebre");
            }else if(gradoCorporal > 39.5 && gradoCorporal <= 41)
            {
                Console.WriteLine("fiebre alta");
            }
            else
            {
                Console.WriteLine($"hipertermia");
            }
        }
    }
}
