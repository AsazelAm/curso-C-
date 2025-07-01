using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    internal class Sala
    {
        //Creamos una propiedad automatica
        public int NumeroSala { get; set; }
        public int Capacidad { get; set; }
        public string TipoProyector { get; set; }
        public string TipoPantalla { get; set; }

        //Creamos cosntructor
        public Sala(int numeroSala, int capacidad, string tipoProyector, string tipoPantalla)
        {
            this.NumeroSala = numeroSala;
            this.Capacidad= capacidad;
            this.TipoProyector = tipoProyector;
            this.TipoPantalla = tipoPantalla;
        }

        public void MostrarInformacionSala()
        {
            Console.WriteLine("Numero de Sala: {0}\nCapacidad: {1}\nTipo de Proyector: {2}\nTipo de Pantalla: {3}", NumeroSala, Capacidad, TipoProyector, TipoPantalla);
        }

    }
}
