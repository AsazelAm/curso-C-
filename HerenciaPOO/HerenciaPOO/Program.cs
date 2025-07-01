using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* HERENCIA
             * Es un mecanismo de la POO que permite a ciertas clases adoptar caracteristicas y funcionalidades de otras Clases
             * Uno de los aspectos principales por las que utilizamos de codigo
             * Podemos crear una clase que herede caracteristicas de otra para no tener que devolver a escribirlas
             * Para poder pasar las clases una tiene que ser la Clase Padre o Clase Base
             * Luego estan las clases derivadas donde var a hacer las clases que van a heredar 
               las caracteristicas y los comportamientos de la clase base
             */

            //Nos sale error por q nos pide parametros
            //Los primeros 3 parametros viajan al constructor padre y el ultimo se queda enla clase derivada
            Perro perro = new Perro(4,true, true,"Rojizo");
            //perro.DarAmor();
            Console.WriteLine(perro.MostrarInfo());

           // Gato gato = new Gato(4,true, true, "Lizo");
           // gato.Maullar();
           // gato.Entrener();


        }
    }
}
