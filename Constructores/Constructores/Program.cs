using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constructores
            /*Los constructores son metodos especiales que le dan un estado inicial a las clases*/
            //Por q se coloca el Telefono() realmente estamos llamando al constructor de la clase Telefono
            Telefono telefono= new Telefono();
            //telefono.ObtenerMemoria(); no me deja ver el valor por q no le estamos mostrando en la consola
            Console.WriteLine(telefono.ObtenerMemoria());

            Telefono telefono2 = new Telefono(256,8,170,20,true);
            Console.WriteLine(telefono2.ObtenerMemoria());

        }
    }
}
