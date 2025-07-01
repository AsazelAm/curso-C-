public class Ejemplo_01_05_01a
{
    public static void Main()
    {
        /*Operadores matematicos
         + suma
         - resta
         * multiplicacion
         / Division
         % Resto de la Division
         */

        System.Console.WriteLine("El resto de Dividir 19 entre 5 es:");
        System.Console.WriteLine(19 % 5);
        System.Console.WriteLine(12 * 13);
        System.Console.WriteLine(321 - 213);
        System.Console.WriteLine(301 / 3);
        System.Console.WriteLine(301 % 3);

        //Orden de Prioridad
        System.Console.WriteLine("Ejemplo de precedencia de Operadores Aritmeticos");
        System.Console.WriteLine("3+4*5= ");
        System.Console.WriteLine(3 + 4 * 5);

        System.Console.WriteLine("Calcular el resultado de las Sgt Operaciones Aritmeticas");
        System.Console.WriteLine("-2 +3*5");
        System.Console.WriteLine(-2 + 3 * 5);
        System.Console.WriteLine("(20+5)%6");
        System.Console.WriteLine((20 + 5) % 6);
        System.Console.WriteLine("15 + -5*6/10");
        System.Console.WriteLine(15 + -5 * 6 / 10);
        System.Console.WriteLine("2+10/5*2-7%1");
        System.Console.WriteLine(2 + 10 / 5 * 2 - 7 % 1);
        System.Console.WriteLine("Presiona Enter Para Salir...");
        Console.ReadLine();//esta linea de codigo se usa para evitar que la consola se cierre inmdiatamente
                           //esperara hasta que el usuario le de enter
    }
}
