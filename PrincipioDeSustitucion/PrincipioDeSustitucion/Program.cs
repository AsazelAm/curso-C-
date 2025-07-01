using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioDeSustitucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Principio de Sustitucion De Liskov
             * Este principio hace referencia a la capacidad que tienen las clases derrivadas (hijas) 
               de sustituir a la clase padre y que el resto del codigo siga funcionando de forma correcta
                
                Gracias a los principios de la Sustitucion puedo instanciar un objeto de la clase perro y almacenarlo en un objeto
                de la clase Mascota por q en este ejemplo un perro es una mascota
                Mascota perro = new Perro();

                pero no puedo instanciar un objeto de la clase Mascota y almacenarlo en un objeto de la clase perro 
                por q ahi se pierde la sustitucion
                Perro perro = new Mascota();
             */

            /*Nosotros no podemos usar los metodos propios de las clases hijas si es q estamos almacenandolo o estamos aplicando
             el principio de sustitucion es decir almacenandolo en la clase padre solo permite acceder a los metodos de Mascota
            
             /*Console.WriteLine(perro.MostrarInfo());
            Console.WriteLine(gato.MostrarInfo());
            Console.WriteLine(hamster.MostrarInfo());*/
            
            Mascota perro = new Perro(4, true, true, "Rojiso");

            Mascota gato = new Gato(4, true, true, "Liso");

            Mascota hamster = new Hamster(4, true, true, 90);

            perro.Entrener();
            gato.Entrener();
            hamster.Entrener();

            //Su mayor potencial esta en los arrays
            //Creamos el array de la classe Mascota y lo inicializamos con un tamaño de 10
            Mascota[] mascotas = new Perro[10];
            //Querremos almacenar en la primera posicion del array vamos a instanciar un objeto de la clase Perro
            mascotas[0] = new Perro(4, true, true, "Rojiso");
            mascotas[1] = new Gato(4, true, true, "Lizo");
            mascotas[2] = new Hamster(4, true, true, 80);

            //CASTING DE OBJETOS
            //lOS casting nos permite hacer un tipo de conversion de un tipo de dato a otro diferente siempre y cuando sea compatible
            int numero = (int)50.5;

            //Ahora estoy convirtiendo un objeto de la clase mascota a un objeto de la clase perro con el casting
            Perro perro1 = (Perro)perro;//Hacemos un casting y lo almacenamos en una clase Perro
            perro1.Ladrar();  //Despues del casting nos permite acceder a los metodos

            Mascota[] macotas = new Mascota[3];
            mascotas[0] = new Perro(4, true, true, "Rojiso");
            mascotas[1] = new Gato(4, true, true, "Lizo");
            mascotas[2] = new Hamster(4, true, true, 80);

            Perro perroo1 = (Perro)mascotas[0];
            Gato gato1 = (Gato)mascotas[1];
            Hamster hamster1 = (Hamster)macotas[2];

            perroo1.Ladrar();
            gato1.Maullar();
            hamster1.Gruñir();


        }
    }
}
