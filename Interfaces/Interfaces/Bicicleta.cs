using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Bicicleta:IVehiculo
    {
        public int Velocidad { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("La Bicicleta acelera pisando el acelerador");
            Velocidad = 4;
        }
        public void Detenerce()
        {
            Console.WriteLine("La bicicleta se esta deteniendo");
            Velocidad = 0;
        }
    }
}
