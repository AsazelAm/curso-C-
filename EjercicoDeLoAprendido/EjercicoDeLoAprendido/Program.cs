using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicoDeLoAprendido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio q pida Contraseña 
            /*string contraActual = "1234ICode";
            Console.WriteLine("Introduce al Contraseña");
            string contraIntroducida = Console.ReadLine();

            /*if(contraActual == contraIntroducida)
            {
                Console.WriteLine("La contraseña es correcta puedes acceder");
            }
            else
            {
                Console.WriteLine("Has introducidad la contraseña Incorrecta");
            }

            if (contraActual.Equals(contraIntroducida))//.Equals() es un metodo para conparar cadenaDeTexto String
            {
                Console.WriteLine("La contraseña es correcta puedes acceder");
            }
            else
            {
                Console.WriteLine("Has introducidad la contraseña Incorrecta");

            //Bono anual por antiguedad
            Console.WriteLine("Introduce la cantidad de años que llevas enla Empresa");
            double nrAnios = double.Parse(Console.ReadLine());//realizamos una conversion Explicita ocupamos el metodo double.Parse(Console.ReadLine)
            Console.WriteLine("Introduce un salario Mensual");
            double salario = double.Parse(Console.ReadLine());

            double salarioTotal = 0;
            if(nrAnios >= 1 && nrAnios < 2)
            {
                salarioTotal = salario + (salario * 0.15);
            }
            else if(nrAnios >= 2 && nrAnios <= 5)
            {
                salarioTotal = salario + (salario * 0.20);
            }
            else if(nrAnios >5)
            {
                salarioTotal = salario * 1.25;//otra forma de sacar el promedio
            }
            else
            {
                Console.WriteLine("No cumples con los requisitos para recibir un bono");
            }

            if(salarioTotal > 0)
            {
                Console.WriteLine($"El salario total con el bono incluido es de {salarioTotal}");
            }
            else
            {
                Console.WriteLine("Tu Salario es de {0}", salario);
            }
            }*/


            //condicionalSwich mes que corresponde
            Console.WriteLine("Introduce un numero del 1 al 12 para mostrar Mes");
            int mes = int.Parse(Console.ReadLine());

            switch (mes)//se ocupa para evaluar un solo valor
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("ABRIL");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("numero equivocado");
                    break;
            }
            
        }
    }
}
