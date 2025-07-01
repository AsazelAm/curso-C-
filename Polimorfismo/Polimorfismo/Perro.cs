using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Perro:Mascota
    {
        private string _color;

        public Perro(int patas, bool tienePatas, bool tienePelajes, string color) : base(patas, tienePatas, tienePelajes)
        {
            _color = color;

        }
 
        public string MostrarInfo()
        {
            return "El perro tiene: " + GetPatas() + " patas y un color: " + _color;
        }

        public override void hacerSonido()
        {
            Console.WriteLine("El perro Ladra");
        }
    }
}
