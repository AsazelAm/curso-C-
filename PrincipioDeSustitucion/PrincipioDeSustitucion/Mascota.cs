using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioDeSustitucion
{
    internal class Mascota
    {
        //Los atributos o campos de clases 
        //protected int _patas;

        private int _patas;
        private bool _tienePatas;
        private bool _tienePelaje;

        //Constructor
        /*Al yo tener un constructor en la clase Padre automaticamente me esta obligando a cada una de sus clases hijas o derrivadas
          heredar ese constructor entonces tenemos que crear un constructor de la clase hija para q nosotros podamos llamar al constructor
          de la clase padre
         */

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
    }
}
