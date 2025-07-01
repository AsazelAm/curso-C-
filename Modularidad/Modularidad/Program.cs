using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Modularidad
            /*Consiste en Dividir el programa en partes mas pequeñas llamadas modulos los cuales tendran su 
             propio funcionamiento y trabajaran en conjunto para hacer que el programa funcione en su totalidad
            * permite la reutilizacion de codigo
            * promueve el trabajo en equipo
            * el mantemiento del codigo sera mar sencillo
            * permite la indentificacion de errores de forma mas rapida
             */
            Automovil auto1 = new Automovil();
            auto1.Arrancar();

            //Encapsulacion
            //es simplemente un sitema o un mecanismo de seguridad q va ocultar el estado de los atributos y metodos de una clase
            //Desde haca llamamos el peso de la rueda
            auto1.MostrarInfor();
        }
    }
}
