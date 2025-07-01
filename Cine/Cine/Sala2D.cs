using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    internal class Sala2D:Sala
    {
        public string SistemasSonidos { get; set; }

        public Sala2D (int numeroSala, int capacidad, string tipoProyector,string tipoPantalla,string sistemaSonido)
            : base(numeroSala, capacidad, tipoProyector, tipoPantalla)
        {
            SistemasSonidos = sistemaSonido;
        }
        public void MostrarInformacionSala2D()
        {
            MostrarInformacionSala(); //si no lo colamos solo nos sales informacion de las gafas y desde el programaPrincipal lo 
            //deveriamos de llamar
            Console.WriteLine("Sistema de Sonido: {0}\n", SistemasSonidos);
        }
    }
}
