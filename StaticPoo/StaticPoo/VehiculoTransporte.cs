using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPoo
{
    internal class VehiculoTransporte
    {
        
        /*Haci se declara una variable de modificador static se puede decir que es una variable Global 
         * q pertenece de la clase y no de instancia
         //Se puede tener tanto como variables static igualmente metodos static
         * Podemos usar una variable o atributo statico dentro de un metodo de instancia pero no podemos usar una variable de instancia
         * dentro de un metodo statico
         */
        public static double tarifa;

        private string _tipo;
        private string _color;
        private string _matricula;

        public VehiculoTransporte(string tipo, string color, string matricula)
        {
            _tipo = tipo;
            _color = color;
            _matricula = matricula;
            tarifa = 1;
        }

        //Getter y Setter de cada uno de los atributos
        public void SetTipo(string tipo) 
        {
            _tipo = tipo;
        }
        public string GetTipo()
        {
            return _tipo;
        }

        public void SetColor(string color)
        {
            _color = color;
        }
        public string GetColor()
        {
            return _color;
        }
        
        public void SetMatricula(string matricula)
        {
            _matricula = matricula;
        }
        public string GetMatricula()
        {
            return _matricula;
        }
        public void MostrarTarifa()
        {
            //Se declara para saber que es una variable static se coloca el propio nombre de la clase
            Console.WriteLine("La tarifa actual es de {0} ",VehiculoTransporte.tarifa);
        }
        public static void AumentoTarifa()
        {
            VehiculoTransporte.tarifa += VehiculoTransporte.tarifa * 0.1;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("Tipo de vehiculo: {0}\nColor: {1}\nMatricula: {2}", _tipo, _color, _matricula);
        }
    }
}
