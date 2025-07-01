using System;//Es el que
using System.Collections.Generic;
using System.Linq;                  //Todas estos nos ayudan para los metodos
using System.Text;                  //son todos NamesPace
using System.Threading.Tasks;

namespace PrimerProyecto //todo proywcto debe tener por lo menos una class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola Mundo");//Console pertenece al namespace System
                                            //WriteLine nos permite escribir para la consola mostrar y nos deja un salto de linea

            //Variables y Constantes
            //Una variabel es un contenedor donde almacena un valor donde puede cambiar el valor lo que hace es sobreEscribir el valor
            //en c# no se puede ocupar una variabel sin un valor

            //Tipo de dato
            int numeroEntero;
            double numeroDecimal; //Permite entero y decimales
            float Decimal;
            string texto = "Esto es un texto de prueba";

            // Constantes
            const int CONSTANTES = 100;// LAS CONSTANTES DEBEN DECLARARSE E INICIALIZARSE EN EL MISMO LUGAR
            numeroEntero = 3;
            numeroDecimal = 2.3;
            Decimal = 23.3F;//SE DEBE COLOCAR F alfinal del valor del decimal

            //VARIABLES IMPLICITAS
            //Se cola var (nombreVariable)= asignamos el valor;
            //El mismo programa  ose el Compilador grasias ala palabra reservada var se encargara de colocarle el valor el tipo de Dato
            var numero= 23;//para ocupar la variable implicita se debe declarar e inicializar en el mismo lugar
            //No puede asignarle otro valor de otro tipo mas adelante una vez que se le asigna el tipo de dato ese es el va a quedar
            //con el hasta el fin del programa
            //le coloco el valor y si le quiero colocar otro ya no lo acepta;
            
            //numero = 23,3;//no se puede cambiar a un float porq ya se coloca de tipo entero

            double kilo = 20.2;
            //Forma de Concatenacion
            Console.WriteLine("Mi peso es " + kilo);

            //forma 2 metodo de interpolacion de cadenas
            Console.WriteLine($"Mi pose es de {kilo}  kilo");// si o si se coloca el $ antes de la comilla

            //forma 3 metodo con parametro
            Console.WriteLine("mi peso {0}", kilo);

        }
    }
}
