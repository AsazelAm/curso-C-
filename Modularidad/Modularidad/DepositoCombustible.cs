using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularidad
{
    internal class DepositoCombustible
    {
        private double capacidad;
        private string tamano;

        Rueda rueda = new Rueda();//Estamos instanciando a la clase Rueda

        /*Desde esta clase llamamos al metodo de la clase rueda q nos pide un dato */
        public void ObteniedoPeso()
        {
           rueda.AsignarPeso(10.5);
            Console.WriteLine("El peso de la rueda es: "+ rueda.ObteniendoPeso());
        }

        public void AlmacenarCombustible()
        {
            Console.WriteLine("Almacenamiento de Combustible del Automovil");


        }
    }
}
