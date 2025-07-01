using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IVehiculo
    {//Un interfase debe tener metodos Abstracto donce podemo OMITIR la palabra Abstract y omitir el modificador de Acceso
        //Obligamos a todos los elementos hijos a q tenga este metodo interface
        void Acelerar();
        void Detenerce();

        //creamoa una propiedad
        int Velocidad { get; set; }

    }
}
