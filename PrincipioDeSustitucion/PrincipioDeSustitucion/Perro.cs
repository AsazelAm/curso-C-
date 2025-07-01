using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioDeSustitucion
{
    internal class Perro:Mascota
    {
        private string _color;

        public Perro(int patas, bool tienePatas, bool tienePelajes, string color) : base(patas, tienePatas, tienePelajes)
        {
            _color = color;

        }
        public void Ladrar()
        {
            Console.WriteLine("El perro ladra");
            //Console.WriteLine(_patas);//Nos deja acceder a la variable protected solo se ocupa cuando sea meramente nesesario
        }
        public string MostrarInfo()
        {
            return "El perro tiene: " + GetPatas() + " patas y un color: " + _color;
        }
    }
}
