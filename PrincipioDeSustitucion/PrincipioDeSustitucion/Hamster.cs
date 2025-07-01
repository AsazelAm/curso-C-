using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioDeSustitucion
{
    internal class Hamster:Mascota
    {
        private double _peso;

        public Hamster(int patas, bool tienePatas, bool tienePelaje, double peso) : base(patas, tienePatas, tienePelaje)
        {
            this._peso = peso;
        }
        public void Gruñir()
        {
            Console.WriteLine("El hamster gruñe o bufa");
        }
        public string MostrarInfo()
        {
            return "El hamster tiene: " + GetPatas() + " patas y un peso de: " + _peso + " gramos";
        }
    }
}
