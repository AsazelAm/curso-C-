using System.Diagnostics.CodeAnalysis;

public class Ejercicio1_6_1_1
{
    public static void Main()
    {
        /*Los identificadores son los nombres que les damos a las variables no debe enpezar por
         int 1numero;
        int un numero;
        int año1;
        int MásDatos;

        pero si con:
        int Algo;
        int algo;
        int _facil;
        int fa_cil;
         */
        int suma;
        int tercerNumero = 234;//le podemo asignar el valor en el mismo momento que la inicializamos
        /*int primerNumero; lo inisializamos y le decimos que es de tipo Entero int
        primerNumero = 234;le colocamos el valor*/
        /*int PrimerNumero, segundoNumero;Si ambos son del mismo tipo de valor se puede declarar en una linea*/
        int primerNumero = 234, segundoNumero = 567;
        suma = primerNumero + segundoNumero;
        /*Si queremos Mostra un texto PREFIJADO ADEMAS DEL VALOR de la variable podemo indicar el texto entre Comilla 
         * DETALLANDO CON {0} en qeu parte de dicho de texto queremos que aparesca el valor de las variables de la SGT forma*/
        System.Console.WriteLine("la suma es {0}.", suma);
        System.Console.WriteLine("La suma de {0} y {1} es {2}", primerNumero, segundoNumero, suma);

        //EJERCISIO
        //S PROPUEESTOS
        System.Console.WriteLine("EJERCICIOS PROPUESTOS");
        int p1, p2, producto;
        p1 = 121;
        p2 = 132;
        producto = p1 * p2;
        System.Console.WriteLine("El calculo del producto de {0} * {1} es {2} ",p1,p2,producto);

        int Cs1 = 285, Cs2 = 1396, resultadoSuma;
        resultadoSuma = Cs1 + Cs2;
        System.Console.WriteLine("El resultado de la suma entre {0} + {1} = {2}", Cs1, Cs2, resultadoSuma);


        System.Console.WriteLine("Presion enter para Salir...");
        Console.ReadLine();
    }
}
