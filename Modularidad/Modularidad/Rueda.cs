using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularidad
{
    internal class Rueda
    {
        private double peso;
        private string tamano;
        private string tipo;
        private string material;

        /*Acar recibe el valor que le paso desde la otra clase pero no lo muestra solo lo asigna el valor al atributo peso*/
        public void AsignarPeso(double p)
        {
            peso = p;
        }
        //aca retornamos el valor del peso 
        public double ObteniendoPeso()
        {
            return peso;
        }

        public void Desplazar()
        {
            Console.WriteLine("El neumatico desplaza el automovil");
        }
    }
}
