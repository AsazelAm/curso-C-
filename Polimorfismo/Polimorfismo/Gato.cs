using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Gato:Mascota
    {
        private string _tipoPelaje;

        public Gato(int patas, bool tienePatas, bool tienePelaje, string tipoPelaje) : base(patas, tienePatas, tienePelaje)
        {
            _tipoPelaje = tipoPelaje;
        }
        

        public string MostrarInfo()
        {
            return "El gato tiene: " + GetPatas() + " patas y un pelaje: " + _tipoPelaje;
        }
        public override void hacerSonido()
        {
            Console.WriteLine("El Gato Maulla");
        }
    }
}
