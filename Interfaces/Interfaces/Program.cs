using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*INTERFACES
             Son estructuras donde podemos definir metodos y propiedades que deberan ser usadas 
            obligatoriamente por las clases que implementen la interfaz
            -Nos permiten cumplir con un diseño correcto para nuestro programa
            -Una clase puede implementar varias interfaces lo que soluviona la fata de herencia multiple en c#*/
            Auto auto = new Auto();
            Bicicleta bici = new Bicicleta();
            auto.Acelerar();
            auto.Detenerce();

            bici.Acelerar();
            bici.Detenerce();
        }
    }
}
