using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Getters y Setters
            /*Nos va a permitir asignar u obtener valores de los atributos q nosotros establescamos en cada uno de nuestra clases*/

            Pelota pelota1 = new Pelota();
            pelota1.MostrarInfoPelota();

            pelota1.SetPeso(200);
            pelota1.SetColor("Rojo");
            //Console.WriteLine(pelota1.GetPeso());

            
            pelota1.MostrarInfoPelota();
        }
    }
}
