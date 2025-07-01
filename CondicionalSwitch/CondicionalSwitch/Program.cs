using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 5; 
            //Primero le pasamos una variable en el parentesis o el valor 
            //luego crearemos los casos q queremos evaluar
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Estes es el numero 1");
                    break;
                case 2:
                    Console.WriteLine("Este es el numero 2");
                    break;//El break es una palabra reservada que permite que tras que se cumpla la case hara q el flujo de ejecucion se rompa y salgamos
                case 3:
                    Console.WriteLine("Este el Numero 3");
                    break;
                default: //se Coloca el default si no se cumple ningun caso o la condicion
                    Console.WriteLine("Ninguno de los valores anteriores concide");
                    break;
            }
            Console.WriteLine("ya hemos salido del switch");

            //El switch permite comparar o evaluar cadena de texto
            string operacion = "Multiplicacion";
            int num1 = 10;
            double num2 = 5;
            switch (operacion)
            {
                case "Suma":
                    Console.WriteLine(num1 + num2);
                    break;
                case "Resta":
                    Console.WriteLine(num1 - num2);
                    break;
                case "Multiplicacion":
                    Console.WriteLine(num1 * num2);
                    break;
                case "Divicion":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("El valor ques estas pasando al swich no coinciden con nunguno de los casos");
                    break;
            }

            //Permite evaluar caracteres
            char Operaciones = '+';
            switch (Operaciones)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("El valor que estas pasando al switch no coinciden");
                    break;
            }

        }
    }
}
