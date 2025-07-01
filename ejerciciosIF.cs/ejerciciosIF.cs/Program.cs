using System;
public class ejercicioIF
{
    public static void Main()
    {
        //Ejercicio 1 INDIQUE EL NUMERO MAYOR
        /*int a, b;
        Console.WriteLine("Ingres el primer Numero");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingres el segundo Numero");
        b = Convert.ToInt32(Console.ReadLine());
        if(a > b)
        {
            Console.WriteLine("el mayor es {0}", a);
        }
        else
        {
            Console.WriteLine("El mayor es {0}", b);
        }

        //EJERCICIO 2 Indique si es mayor o menor que 0
        int c;
        Console.WriteLine("EJERCICIO 2 Indique si es mayor o menor que 0");
        Console.Write("Ingrese un numero: ");
        c = Convert.ToInt32(Console.ReadLine());
        if(c > 0)
        {
            Console.WriteLine("{0} es mayor que Cero",c);
        }
        else
        {
            Console.WriteLine("{0} es menor que Cero",c);
        }

        //EJERCICIO 3 INDIQUE SI SON IGUALES
        Console.WriteLine("EJERCICIO 3 INDIQUE SI SON IGUALES");
        int d, e;
        Console.WriteLine("Ingrese un Numero");
        d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese un Segundo Numero");
        e = Convert.ToInt32(Console.ReadLine());
        if(d == e)
        {
            Console.WriteLine("{0} es igual que {1}", d, e);
        }
        else
        {
            Console.WriteLine("{0} No Es igual que {1}", d, e);
        }
        
        //Estructura De Control Multiple
        //EJERCICIO 4 INDIQUE CUAL ES EL MAYOR DE LOS 3 NUMEROS
        Console.WriteLine("EJERCICIO 4 INDIQUE CUAL ES EL MAYOR DE LOS 3 NUMEROS");
        int f, g, h;
        Console.WriteLine("Ingrese 3 numeros:");
        f = Convert.ToInt32(Console.ReadLine());
        g = Convert.ToInt32(Console.ReadLine());
        h = Convert.ToInt32(Console.ReadLine());
        if(f > g)
        {
            if (f > h)
            {
                Console.WriteLine("El numero Mayor es {0}", f);
            }
            else
            {
                Console.WriteLine("El numero Mayor es {0}", h);
            }
        }
        else
        {
            if(g > h)
            {
                Console.WriteLine("El numero mayor es {0}", g);
            }
            else
            {
                Console.WriteLine("El numero mayoe es {0}", h);
            }
        }

        //EJERCICIO 5 INDIQUE SI ES MAYOR O IGUAL QUE 200 O SI ES PAR
        Console.WriteLine("EJERCICIO 5 INDIQUE SI ES MAYOR O IGUAL QUE 200 O SI ES PAR");
        int i;
        Console.WriteLine("Ingrese un Numero");
        i = Convert.ToInt32(Console.ReadLine());
        if(i >= 200)
        {
            Console.WriteLine("Es mayor o Igual a 200");
            if(i % 2 == 0)
            {
                Console.WriteLine("Es un numero PAR");
            }
            else
            {
                Console.WriteLine("No es Un Numero Par es IMPAR");
            }
        }
        else
        {
            Console.WriteLine("No es Mayor Que 200");
            if (i % 2 == 0)
            {
                Console.WriteLine("Es un numero PAR");
            }
            else
            {
                Console.WriteLine("No es Un Numero Par es IMPAR");
            }
        }
        
        //Ejercicio 6 Muestre un mensaje si Es Mayor que 100 y es inpar
        Console.WriteLine("Ejercicio 6 Muestre un mensaje si Es Mayor que 100 y es inpar");
        int j;
        Console.WriteLine("Ingrese un numero");
        j = Convert.ToInt32(Console.ReadLine());
        if((j > 100) && (j % 2 == 1))
        {
           Console.WriteLine("{0} es Mayor que 100 y es Inpar", j);
        }

        //EJERCICIO 7 MUESTRE EL VALOR ABSOLUTO DE UN NUMERO INTRODUCIDO
        Console.WriteLine("EJERCICIO 7 MUESTRE EL VALOR ABSOLUTO DE UN NUMERO INTRODUCIDO");
        int k,l;
        Console.WriteLine("Ingrese un Numero");
        k = Convert.ToInt32(Console.ReadLine());
        if(k >= 0)
        {
            Console.WriteLine(k);
        }
        else
        {
            l = k * (-1);
            Console.WriteLine("El valor absoluto es "+ l);//se llama concatenar
        }

        //EJERCICIO 8 INDIQUE SI ES PAR o INPAR
        Console.WriteLine("EJERCICIO 8 INDIQUE SI ES PAR o INPAR");
        int m;
        Console.WriteLine("Ingrese un numero");
        m = Convert.ToInt32(Console.ReadLine());
        if(m % 2 == 0)
        {
            Console.WriteLine("{0} es un numero par ", m);
        }
        else
        {
            Console.WriteLine(m + " ES UN NUMERO INPAR");
        }
        
        //Ejercicio 8 indique importe bruto de una factura y determine el importe neto
        Console.WriteLine("Ejercicio 8 indique importe bruto de una factura y determine el importe neto");
        int n;
        double o;
        Console.Write("Introdusca un Numero ");
        n = Convert.ToInt32(Console.ReadLine());
        if(n > 20000)
        {
            o = n - (n * 0.15);
            Console.WriteLine("Tiene el descuento del 15% el importe a pagar es {0}", o);
        }
        else
        {
            Console.WriteLine(n + " No tiene descuento el importe a pagar es {0}", n);
        }

        //EJERCICIO 9 SUELDO SEMANAL DE LOS TRABAJADORES
        Console.WriteLine("EJERCICIO 9 SUELDO SEMANAL DE LOS TRABAJADORES");
        int p, q ,r;
        double c;//lo colocamo para declarar el tipo de dato flotante o decimal
        Console.WriteLine("introduce las horas trabajadas para la paga");
        p = Convert.ToInt32(Console.ReadLine());
        if(p > 40)
        {
            q = p - 40;
            c = (40 * 20) + (q * 25);
            Console.WriteLine("Se le debe Pagar con las horas extras " + c);
        }
        else
        {
            r = p * 20;
            Console.WriteLine("Se le debe pagar {0}", r);
        }
        
        //EJERCICIO 10 INDIQUE SI AMBOS NUMEROS SON PARES
        Console.WriteLine("EJERCICIO 10 INDIQUE SI AMBOS NUMEROS SON PARES");
        int s, t;
        Console.WriteLine("Ingrese un numero");
        s = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo Numero");
        t = Convert.ToInt32(Console.ReadLine());
        if ((s % 2 == 0) && (t % 2 == 0)) {
            Console.WriteLine(s + " y {0} Son Numeros pares", t);
        }
        else
        {
            Console.WriteLine("{0} o {1} no son Pares", s, t);
        }
        */
        //EJERCICIO 11 INDIQUE EL DIA DE LA SEMANA DEL 1 AL 7
        Console.WriteLine("EJERCICIO 11 INDIQUE EL DIA DE LA SEMANA DEL 1 AL 7");
        int u;
        Console.WriteLine("INGRESE UN NUMERO DEL 1 AL 7 PARA DECIR QUE DIA ES EL DIA DE LA SEMANA");
        u = Convert.ToInt32(Console.ReadLine());
        if(u > 7)
        {
            Console.WriteLine("Ingrese un numero del 1 al 7 para los dias de la Semana");
            u = Convert.ToInt32(Console.ReadLine());
        }
        if (u == 1)
        {
            Console.WriteLine("{0} es Lunes", u);
        }
        else
        {
            if (u == 2)
            {
                Console.WriteLine(u + " Es Martes");
            }
            else
            {
                if( u == 3)
                {
                    Console.WriteLine(u + " Es Miercoles");
                }
                else
                {
                    if(u == 4)
                    {
                        Console.WriteLine("{0} es Jueves", u);
                    }
                    else
                    {
                        if(u == 5)
                        {
                            Console.WriteLine(u + " es Viernes");
                        }
                        else
                        {
                            if(u == 6)
                            {
                                Console.WriteLine(u + " es Sabado");
                            }
                            else
                            {
                                if(u == 7)
                                {
                                    Console.WriteLine("{0} es Domingo", u);
                                }
                                else
                                {
                                    Console.WriteLine("NUMERO INVALIDO");
                                }
                            }
                        }
                    }
                }
            }
        }
        // Ejercicio 12 Mostrar Mensaje segun la nota obtenida
        Console.WriteLine("Ejercicio 12 Mostrar Mensaje segun la nota obtenida");
        int w;
        Console.WriteLine("Introducir la nota Obtenida");
        w = Convert.ToInt32(Console.ReadLine());
        if( w > 100)
        {
            Console.WriteLine("Introducir un numero del 1 al 100");
        }
        if(w <= 45)
        {
            Console.WriteLine("Su nota es " + w + " tiene un mal desempeño");
        }
        else
        {
            if(w <= 60)
            {
                Console.WriteLine("Su nota es {0} Debe Mejorar", w);
            }
            else
            {
                if( w <= 70)
                {
                    Console.WriteLine("Su nota es {0} ES UNA NOTA SATISFACTORIA", w);
                }
                else
                {
                    if(w <= 80)
                    {
                        Console.WriteLine("Su nota es " + w + " Es una nota Buena");
                    }
                    else
                    {
                        Console.WriteLine("ES UNA NOTA EXCELENTE");
                    }
                }
            }
        }
        //EJERCICIO 13 INTRODUCIR LAS NOTAS Y SACAR EL PROMEDIO Y DECIR SI APROBO O NO 
        Console.WriteLine("EJERCICIO 13 INTRODUCIR LAS NOTAS Y SACAR EL PROMEDIO Y DECIR SI APROBO O NO");
        int a, b, c, d;
        double e;
        Console.WriteLine("Introducir la primera nota");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("introducir la segunda nota");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introducir la tercera Nota");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("introducir la Cuarta Nota");
        d= Convert.ToInt32(Console.ReadLine());
        e = (a + b + c + d) / 4;
        if( e >= 61)
        {
            Console.WriteLine("Su promedio es {0} usted esta APROBADO", e);
        }
        else
        {
            Console.WriteLine("Su promedio es {0} usted NO ESTA APROBADO", e);
        }
        Console.ReadKey();//Para que se detenga en la Consola

    }
}
