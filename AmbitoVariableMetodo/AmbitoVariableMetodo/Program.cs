using System;

internal class Program
{
    int numero1 = 1;//se declara la variable de manera Global
    static void Main(string[] args)
    {

        //Prueba();
        //Console.WriteLine(Suma(5, 8));

        Random random = new Random();//Estamos creando un objeto de la clase Randon
        Console.WriteLine( random.Next());
        Console.WriteLine(int.MaxValue);//para saber el maximo valor del Entero

        Console.WriteLine(random.Next(5,10));

        /*El compilador sabe a cual metodo llamar dependiendo al numero de argumentos o parametro coloq*/
        Console.WriteLine(Suma(5, 10));
        Console.WriteLine(Suma(1, 1, 8));
        Console.WriteLine(Suma(1,1,1,1));
        Console.WriteLine(Suma(2.13, 3));
    }
    public static int Suma(int num1, int num2)
    {
        return num1 + num2;
    }
    public static int Suma(int num1, int num2,int num3)//hasta se le conoce como sobreCarga de Metodos
    {
        return num1 + num2+ num3;
    }
    public static int Suma(int num1, int num2,int num3, int num4)
    {
        return num1 + num2+num3+ num4;
    }
    public static int Suma(double num1, int num2)//acepta el mismo nombre siempre y cuando minimo cambie el tipo de dato de un parametro
    {
        double suma = num1 + num2;
        return (int)suma;//hacemos la conversion de tipo double a Entero
    }

    //La variable se debe declarar dentro del mismo ambito o scope para que se pueda ocupar
    //los parrametros resuelve los problemas porq estamos pasando la variable como parametro a otro ambito o scope

    /* public static void Prueba()
     {
         //ambito o SCOPE O alcance o bloq
         //Console.WriteLine(numero1);

     }

     //SOBRECARGA DE METODS
     //Ramdon class numero aleatorio
     //metodo Next() Nos devuel un numero aleatorio de 0 hasta un numero Entero max int
     /*
      Next(Int32) colocamos hasta q numero va a dar el numero aleatorio
      Next(Int32, Int32) Devuelve un numero aleatorio dentro del intervalo q coloqmos entre dos


     public static int Suma(int num1, int num2)
     {
         return num1 + num2;
     }*/
}
