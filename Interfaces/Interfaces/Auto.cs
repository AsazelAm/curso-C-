using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{                               //Parra colocar dos interfaces a una clase se colaca la comoa
    internal class Auto:IVehiculo, ILlenarTanque //Todo lo qeste dentro del interfas obligatoriamente tiene que estar en clases hija
    {
        //En las clases hijas si se colocal el modificador de Acceso
        public int Velocidad { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("El auto acelera pisando el acelerador");
            Velocidad = 10;
        }
        
        public void Detenerce()
        {
            Console.WriteLine("El auto se esta deteniendo");
            Velocidad = 0;
        }
        public void LlenarTanque()
        {
            Console.WriteLine("Se ha llenado el tanque del auto");
        }

    }
}
