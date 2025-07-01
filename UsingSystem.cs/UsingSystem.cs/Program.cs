using System;//SIEMPRE AL INICIO DEL PROGRAMA
public class ejemplo_01_10a
{
    public static void Main()
    {
        //Console.ReadLine(); con esto codigo podemos hacer qeu el usuario introdusca un dato Para leer los textos
        //Convert.ToInt32; con este convertimo un dato a Numero ENTERO
        // primerNumero=System.Convert.ToInt32(System.Console.ReadLine());
        /*Si ocupamos el using System ya no va ver nesecida de coloca System alos Consoles...
         Es una mejora del codigo y mas practico EL USING SYSTEM SE DEBE COLOCAR AL INICO DELPROGRMA */
        int primerNumero, segundoNumero, suma;
        Console.Write("Introduce el PrimerNumero");
        /*Con Console.Write esCribibos sin avanzar de linea Pero no se puede Utilizar los textos prefijados no 
         se puede ocupar los {0}*/
        primerNumero = Convert.ToInt32(Console.ReadLine());
        //lo que introducimo haca aparece alado de introduce el primero NuMERO NO abajo comoantes
        Console.Write("Introduce el Segundo Numero");
        segundoNumero = Convert.ToInt32(Console.ReadLine());
        suma = primerNumero + segundoNumero;
        Console.WriteLine("La suma de {0} + {1} = {2}", primerNumero, segundoNumero, suma);
        Console.ReadKey();
        
    }
}
