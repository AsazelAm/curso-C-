using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Propiedades tiene relacion con la encapsulacion
            /*Son mecanismo que nos permite leer modificar calcular el valor de una variable de forma flexiblel y mucho mas facil
             */
            Alumno alumno = new Alumno(5.5);
            alumno.Nota=233;//Para modificar el valor de la nota llamamos al metodo Nota getSet
            Console.WriteLine("La nota del alumno es: {0}",alumno.Nota);//parra mostrar llamamos al metodo Nota 

            alumno.Nota1 = 4;
            Console.WriteLine("La otra nota: {0}", alumno.Nota1);

            alumno.Nota2 = -42;
            Console.WriteLine("La otra nota: {0}", alumno.Nota2);
        }
    }
}
