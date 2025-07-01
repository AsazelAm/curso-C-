using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    internal class Sala3D:Sala
    {
        public string TipoGafas { get; set; }
        
        public Sala3D(int numeroSala, int capacidad, string tipoProyector, string tipoPantalla, string tipoGafas)
            : base(numeroSala, capacidad, tipoProyector, tipoPantalla)
        {
            this.TipoGafas = tipoGafas;
        }

        public void MostrarInformacionSala3D()
        {
            MostrarInformacionSala();
            Console.WriteLine("Tipo de Gafas: {0}\n", TipoGafas);
        }
    }
}
