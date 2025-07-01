using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class ClasePadre
    {
        //Ocultacion de metodo
        public void MostrarMensaje()
        {
            Console.WriteLine("Mensaje desde la clase padre");
        }

        //SobreEscritura
        //Colocamos la palabra reservada Virtual es como si estubieramos anulando este medoto y esperando un remplazo enalguna de las clases hijas
        public virtual void Mensaje() 
        {
            Console.WriteLine("Mensaje desde la clase Padrre");
        }
    }
}
