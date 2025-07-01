using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPOO
{
    internal class Hamster:Mascota
    {
        private double _peso;
        
        public Hamster(int patas, bool tienePatas, bool tienePelaje, double peso) : base(patas, tienePatas, tienePelaje)
        {
            this._peso=peso;
        }
        public void Gruñir()
        {
            Console.WriteLine("El hamster gruñe o bufa");
        }
    }
}
