using System;
public class Ejemplo_02_01_01a
{
    public static void Main()
    {
        //Condicion if
        //declaracion if(condicion) Sentencia;
        int numero;
        Console.WriteLine("Introduce Numero");
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero == 0) 
            Console.WriteLine("El numero es positivo");

        //Ejercicio Propuesto
        int x;
        Console.WriteLine("Introduce un Numero para determinar si Es PAR:");
        x = Convert.ToInt32(Console.ReadLine());
        if (x % 2 == 0)
        {//if Sentencia Compuesta
            Console.WriteLine("El numero Introducido es PAR");
        }
        //if-else
        int n;
        Console.WriteLine("Introduce un numero:");
        n = Convert.ToInt32(Console.ReadLine());
        if (n > 0)
            Console.WriteLine("El Numero es Positivo");
        else
            Console.WriteLine("El numero es 0 o negativo");

        //Ejercicio Propuesto
        int Nu;
        Console.WriteLine("Introduce un Numerooo:");
        Nu = Convert.ToInt32(Console.ReadLine());
        if (Nu > 0)
            Console.WriteLine("El numero es Mayor que cero");
        else
            if (Nu < 0)
            Console.WriteLine("El Numero es Menor que Cero");
        else
            Console.WriteLine("El Numero es Cero 0");

        //Operadoeres Logicos
        /*
            && ampersan         Y
            || pibe             O
            !  Diferente        No
         */
        int n1, n2;
        Console.WriteLine("Introduce el primer Numero");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el Segundo Numero");
        n2 = Convert.ToInt32(Console.ReadLine());
        if ((n1 > 0) && (n2 > 0))
            Console.WriteLine("El numero es mayor que Cero");
        else
            Console.WriteLine("Los numeros No Son Mayor Que Cero");

        //Operador Condicional o OPERADOR TERNARIO
        //Declaracion           nombreDeLaVariable = a > b ? valor 1: valor 2;
        //Equibale a decir si se cumple la condicion toma el valor 1 si No toma el valor 2
        int a, b, operacion, resultado;
        Console.WriteLine("ingrese un numero Para la operacion matematica");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero para la Operacion Matematica");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escriba una operacion (1 = resta ; otro = suma): ");
        operacion = Convert.ToInt32(Console.ReadLine());
        resultado = operacion == 1 ? a - b : a + b;
        Console.WriteLine("El resultado es {0} ", resultado);
        Console.ReadKey();
    }
}
