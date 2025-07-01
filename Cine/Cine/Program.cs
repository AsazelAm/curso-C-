using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sala2D sala2D = new Sala2D(1, 59, "Digital", "Estandar", "Dobly surround");
            Sala3D sala3D = new Sala3D(2, 55, "Dolby 3D", "Dolby 3D", "Gafas Polarizadas");

            Console.WriteLine("Informacion de la sala 2D");
            //sala2D.MostrarInformacionSala();
            sala2D.MostrarInformacionSala2D();

            Console.WriteLine("Informacion de la sala 3D");
            //sala3D.MostrarInformacionSala();
            sala3D.MostrarInformacionSala3D();
        }
    }
}
