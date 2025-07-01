using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //POLIMORFISMO
            /* Es un concepto de POO en el que un objeto tiene la capacidad de comportarse de forma diferente en 
               funcion de los distintos objetos que se usen para su invocacion
             */
            
            //Ocultacion de Metodos
            //Creamos un objeto de la clase Padre e Hija
            ClasePadre padre = new ClasePadre();
            ClaseHija hijo = new ClaseHija();

            padre.MostrarMensaje();//Muestra el mensaje del metodo de la clase padre
            hijo.MostrarMensaje();//Muestra el mensaje del metodo de la clase Hija

            //Principio de sustitucion de Liskov
            ClasePadre obj = new ClaseHija();
            obj.MostrarMensaje();//Muestra el mensaje del metodo de la clase padre


            //SobreEscritura de Metodos
            /*Consiste en que nosotros sobreEscribamos*/
            ClasePadre padree = new ClasePadre();
            ClaseHija hijoo = new ClaseHija();
            ClasePadre obje = new ClaseHija();

            padree.Mensaje();
            hijoo.Mensaje();
            obje.Mensaje();

            Mascota[] mascotas = new Mascota[3];

            mascotas[0] = new Perro(4, true, true, "Negro");
            mascotas[1] = new Gato(4, true, true, "Negro");
            mascotas[2] = new Hamster(4, true, true, 80);

            
            for(int i=0; i<mascotas.Length; i++)
            {
                mascotas[i].hacerSonido();
            }








        }
    }
}
