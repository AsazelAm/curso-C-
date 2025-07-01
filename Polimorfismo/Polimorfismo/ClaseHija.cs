using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class ClaseHija:ClasePadre
    {
        /*Cuando tenemos el metodo y la misma cantidad de parametro y con el mismo valor de retorno*/

        //Se coloca new para aplicar la oculatacion de metodo dee manera correcta
        public void MostrarMensaje()
        {
            Console.WriteLine("Mensaje desde la clase hija");
        }

        //SobreEscritura
        //Colocamos override de esa manera estamos sobreEscribiendo el metodo de la clase padre
        public override void Mensaje()
        {
            Console.WriteLine("Mensaje desde la clase hija");
        }
    }
}
