using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importamos el proyecto para poder acceder ala clase del proyecto
using ModificadoresDeAcceso;

/*
   las Solucion son Contenedores de Proyecto 
    cuando el program es mas grande talves sea nesesario crear varios proyectos dentro de la solucion

    clic derecho en Solucio click en agregar y click en nuevo proyecto
 */
namespace ModificadoresPrueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ANTES de poder ocupar la clase se le declara public y se le importa o usar ese proyecto
            Usuario usuario2 = new Usuario();
            usuario2.Contrasena = "123abc";
        }
    }
}
