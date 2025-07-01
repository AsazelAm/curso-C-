using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Mascota
    {
        private int _patas;
        private bool _tienePatas;
        private bool _tienePelaje;

        public int GetPatas()
        {
            return _patas;
        }
        public Mascota(int patas, bool tienePatas, bool tienePelaje)
        {
            _patas = patas;
            _tienePatas = tienePatas;
            _tienePelaje = tienePelaje;
        }

        public void Entrener()
        {
            Console.WriteLine("Esta mascota me Entretiene");
        }
        public void DarAmor()
        {
            Console.WriteLine("Mi mascota me da mucho Amor y CarriñO");
        }

        public virtual void hacerSonido()
        {
            Console.WriteLine("La mascota hace Sonido");
        }
    }
}
