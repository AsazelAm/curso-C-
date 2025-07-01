using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Paradignas de la programcion
            /*Son la metodologia q utiliza un determinado lenguaje de programcion quiere decir un estilo o metodo
             * se divide en:
             * 
             * Programacion Estructurada:Linea por linea se ejecuta
             * Enfoq lineal y procetural
             * Se enfoca en la logica del programa en su totalidad
             * No presenta un sistema de reutilizacion de codigo para otros programas
             * Menos complejo de Depurar
             * 
             * Programacion Orientada a Objeto: quiere que les representemos los objetos con codigo 
             * Abstraccion Modularidad Encapsulamiento Herencia Polimorfismo
             * Presenta un enfoq modular 
             * Permite la reutilizacion de codigo en otros programas a traves de clases
             * Mas dificil de Depurar
             */

            //Clases
            /*Una clase es una plantilla en la que se difine las caracteristicas y funcionalidaddes
             de una entidad o lo q es lo mismo un objeto*/
            //las caracteristicas se Lo conoce Como ATRIBUTOS o Campos de clases
            //las acciones se lo conoce como METODOS

            //Creamos una Instancia del Objeto Computadora
            int numero;
            /*Computadora sansung;//Creamos un objeto de la clase Computadora
            sansung = new Computadora();//Lo instanciamos la palabra new nos permite crear una instancia de la clase Objeto
            */
            //De forma DIRECTA DE INSTANCIAR UN OBJETO DE LA CLASE COMPUTADORA
            //declaracion
            // NombreDElACLASE  NOMBREdelaINSTANCIA = new NombreDeLaclase();
            Computadora samsung = new Computadora();
            samsung.marca = "Samsung";//estamos llamando a esa variable y le estamos asignando un valor
            samsung.anoDeFabricacion = 2024;
            samsung.cantidadRam = 4;
            samsung.esLaptop = false;

            samsung.MostrarInformacion();//llamamos al metodo
            Console.WriteLine();
            Computadora apple = new Computadora();
            apple.marca = "Apple";
            apple.anoDeFabricacion = 2020;
            apple.cantidadRam = 1;
            apple.esLaptop = true;

            apple.MostrarInformacion();
        }
    }
    class Computadora
    {
        public string marca;
        public int anoDeFabricacion;
        public int cantidadRam;
        public bool esLaptop;

        //Si no colocamos la palabra public no nos deja llamar el metodo de otra clase
        //si lo colacamos nos permite accder o llamar destro otro punto del programa
        //la encapsulacion nos permite que tenga una restriccion que todo lo q se coloq dentro no se pueda ser llamado por otra clase
        public void Encender()
        {
            Console.WriteLine("La computadora de marca {0} se esta ensendiendo", marca);
        }
        public void Apagar()
        {
            Console.WriteLine("La computadora de marca {0} se esta ensendiendo", marca);
        }
        public void TransferenciaInformacion()
        {
            if (cantidadRam < 2) Console.WriteLine("Esta computadora no es muy rapido trasfiriendo datos ");
            else if (cantidadRam < 4) Console.WriteLine("Esta computadora transfiere informacion de manera moderada");
            else Console.WriteLine("la computadora transfiero informacion de manera Eficiente");

        }
        public void MostrarInformacion()
        {
            //\n nos permite hacer un salto de linea
            if (esLaptop) //si no se coloca la comparacion True si sobre entiende que esta comparando si es true
                Console.WriteLine("Marca: {0} -- Año de Fabricacion: {1}\nTipo de Ordenador: Laptop", marca, anoDeFabricacion, cantidadRam);
            else Console.WriteLine("Marca: {0} -- Año de Fabricacion: {1}\nTipo de Ordenador: Escritorio", marca, anoDeFabricacion, cantidadRam);

        }
    }
}
