using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ModificadoresPrueba;

namespace ModificadoresDeAcceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Modificadores de aceso
            /*public : Se puede acceder desde cualquier proyecto incluso desde otro proyecto
             *private : Se puede acceder solo desde la misma clase
             *protected : Se puede acceder solo desde la misma clase o una clase derivada(Heredada)
             *internal : Se puede acceder solo desde el mismo ensamblando(Proyecto)
             */

            Usuario usuario1 = new Usuario();
            usuario1.nombre = "ASAF";

            usuario1.IniciarSeccion();
        }
    }

    //Modificador de acceso por defecto de las clases : internal
    //Modificador de acceso por defecto de variables y metodos de clase : private
    public class Usuario
    {
        /* el modificador public nos permite llamarlo desde otra clase incluso proyecto*/
        public string nombre;
        /*El modificador de acceso private solo nos permite ocupar la variable dentro de donde la clase fue creada
         por defecto es private pero por buena practica se declara*/
        private string contrasena;
        public string Contrasena;
        public string email;

        public void IniciarSeccion()
        {
            Console.WriteLine("El usuario {0} acaba de iniciar sesion", nombre);
        }
        public void CerrarSesion()
        {
            Console.WriteLine("El usuario {0} acaba de cerrar sesion", nombre);
        }
        public void CambiarContrasena()
        {
            Console.WriteLine("El usuario {0} acaba de cambiar su contraseña", nombre);
        }
    }
}
