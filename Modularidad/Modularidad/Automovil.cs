using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularidad
{
    internal class Automovil
    {
        Rueda[] ruedas = new Rueda[4]; //creamos un array de este objeto de la rueda y le asignamos el tamaño
        DepositoCombustible depositoCombustible = new DepositoCombustible();

        public void Arrancar()
        {
            Console.WriteLine("El automovil esta arrancando");
        }
        public void Frenar()
        {
            Console.WriteLine("El autovil esta Frenando");
        }

        //En esta clase llamamos al metodo para mostrar el peso dela rueda pero la llamamos desdela principal
        public void MostrarInfor()
        {
            depositoCombustible.ObteniedoPeso();
            for(int i=0; i<ruedas.Length; i++)
            {
                ruedas[i] = new Rueda();//haca accedemos a la rueda en la posicion 0 y luego lo instanciamos al objeto rueda 
                ruedas[i].AsignarPeso(8);//En esta misma rueda la estamos llamando al metodo asignarPeso para asignarle el peso
                Console.WriteLine("rueda nro " + (i + 1) + ": " + ruedas[i].ObteniendoPeso());
                //Haca mostramos cada una de las ruedas su peso

            }
        }
    }
}
