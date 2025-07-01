using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaBuclesCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bucle While
            //numerosPares2al10
            //Ejercicio1();
            //SUMElOSpARES
            //Ejercicio2();
            //CUENTE LOS NUMEROS IMPARES
            //Ejercicio3();
            //CuenteNumerosParesEImpares
            //Ejercicio4();
            //numeros Asendente
            //Ejercicio5();

            //BUCLE DO WHILE
            int n=1, i=0;
            int p = 0;
            int s = 0;
            double c = 0;
            //SobreCarga de Metodos
            //Ejercicio6(n,i);
            //Numeros Pares
            //Ejercicio6(n, i, p);
            //Ejercicio6(n, i, s, c);

            //BUCLE FOR
            double promedio;
            promedio = Ejercicio7();
            Console.WriteLine("El promedio de los  pares es " + promedio);
            //tabla de mutiplicar de un numero
            Ejercicio8();
            //TABLA DE MULTIPLICAR DEL 1 AL 10
            Ejercicio9();
            
        }

        //While
        public static void Ejercicio1()
        {
            Console.WriteLine("----------Mostrar numeros Pares del 2 al 10----------");
            int i;
            i = 2;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"numeros Pares {i}");
                }
                i++;
            }
        }

        public static void Ejercicio2()
        {
            Console.WriteLine("------------SUME LOS NUMEROS PARES---------------");
            int m,n,s=0;
            Console.WriteLine("Introduce el Inicio");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el Tope");
            n = Convert.ToInt32(Console.ReadLine());
            while (m <= n)
            {
                if (m % 2 == 0) 
                {
                    s = s + m;
                }
                m++;
            }
            Console.WriteLine("la suma de todos los numero pares es "+ s);
        }

        public static void Ejercicio3()
        {
            Console.WriteLine("--------------CUENTE NUMERO IMPARES------------");
            int impar = 1;
            int conteo = 0;
            int n;
            Console.WriteLine("El inicio es 1");
            Console.WriteLine("Introduce el tope");
            n = int.Parse(Console.ReadLine());

            while(impar <= n)
            {
                if(impar % 2== 1)
                {
                    conteo = conteo + 1;
                }
                impar++;
            }
            Console.WriteLine($"El conteno de los numeros Impares {conteo}");
        }

        public static void Ejercicio4()
        {
            Console.WriteLine("------------------Contar numero pares impares-------------------");
            int impar = 1;
            int n;
            int conteoIm = 0, conteoPa = 0;
            Console.WriteLine("El inicio es 1");
            Console.WriteLine("Introdusca el Tope");
            n = Convert.ToInt32(Console.ReadLine());
            while(impar<= n)
            {
                if(impar % 2 == 0)
                {
                    conteoPa = conteoPa + 1;
                }
                else
                {
                    conteoIm += 1;
                }
                impar++;
            }

            Console.WriteLine("El conte de los numeros Pares es {0} El conteo de los Numeros IMPARES {1}", conteoPa, conteoIm);
        }

        public static void Ejercicio5()
        {
            Console.WriteLine("-----------Asendente de 2 en 2-----------");
            int inicio=2, tope=8;
            while (inicio <= tope)
            {
                Console.WriteLine(inicio);
                inicio = inicio + 2;
            }
        }
    
        //DO WHILE
        public static void Ejercicio6(int inicio,int tope) 
        {
            Console.WriteLine("---------------Ejercicio DO While------------------");
            Console.WriteLine("Ingrese un numero");
            tope = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(inicio);
                inicio = inicio + 1;
            } while (inicio <= tope);

        
        }

        public static void Ejercicio6(int inicio, int tope, int nume)
        {
            Console.WriteLine("Mostrar numeros Pares");
            Console.WriteLine("Introduce un Numero");
            tope = int.Parse(Console.ReadLine());
            do
            {
                if(inicio % 2 == 0)
                {
                    Console.WriteLine(inicio);
                }
                inicio++;
            } while (inicio <= tope);
        }

        public static void Ejercicio6(int inicio, int tope, int suma , double conteo)
        {
            Console.WriteLine("Cuente los numeros Pares y sume los Impares");
            Console.WriteLine("Ingrese el Tope");
            tope = Convert.ToInt32(Console.ReadLine());

            do
            {
                if(inicio % 2 == 0)
                {
                    conteo = conteo + 1;
                }
                else
                {
                    suma = suma + inicio;
                }

                inicio++;

            } while (inicio <= tope);
            Console.WriteLine($"La cantidad de los numeros pARES ES {conteo} la suma de los impares es {suma}");
        }

        //BUCLE FOR
        public static double Ejercicio7()
        {
            int tope;
            int conteo = 0, suma = 0;
            double prom;
            Console.WriteLine("BUCLE FOR");
            Console.WriteLine("Ingrese el Tope");
            tope = int.Parse(Console.ReadLine());
            for(int i= 1; i<=tope; i++)
            {
                if(i % 2 == 0)
                {
                    conteo = conteo + 1;
                    suma = suma + i;
                }
            }
            prom = suma / conteo;
            
            return prom ;
        }

        public static void Ejercicio8()
        {
            int numero;
            int resultado = 0;
            Console.WriteLine("Tabla de multiplicar de un numero");
            Console.WriteLine("Ingrese el numero");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++) 
            {
                resultado = numero * i;
                Console.WriteLine($"{numero} * {i} = {resultado}");
            }
        }

        public static void Ejercicio9()
        {
            int resultado = 0;
            for(int i= 1; i<= 10; i++)
            {
                for(int j= 1; j<= 10; j++)
                {
                    resultado = i * j;
                    Console.WriteLine($"{i} * {j} = {resultado}");
                }
                Console.WriteLine(" ");
            }
            
        }

    }
}
