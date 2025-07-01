using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Hamster:Mascota
    {
        private double _peso;

        public Hamster(int patas, bool tienePatas, bool tienePelaje, double peso) : base(patas, tienePatas, tienePelaje)
        {
            this._peso = peso;
        }
        
        public string MostrarInfo()
        {
            return "El hamster tiene: " + GetPatas() + " patas y un peso de: " + _peso + " gramos";
        }
        public override void hacerSonido()
        {
            Console.WriteLine("El hamster gruñe");
        }
    }
}
