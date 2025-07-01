using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    internal class Alumno
    {
        private double _nota;
        private double _nota1;

        /*Para crear una propiedad los atributos deben ser privados
         Las propiedades deben de ser publicas colocamo el mismo tipo de dato normalmente se ocupa el mismo nombre de la varible pero 
        la primera letra en MAYUSCULA*/
        public double Nota //Propiedad en c#
        {
            get { return _nota; }
            /*set { if (value < 0) _nota = 0; //lo controlamos el valor que le asigna el ususario
                  else _nota = value; } //value le indicamos que cadaves que ingrese un valo se almacena en value par retornar despues*/
            set { _nota = FiltrandoNota(value); }//Haci filtramos el valor llamamos la funcion y le pasamos el valor 
        }   

        //Propiedad simplificada EXPRESIONES LAMBDA
        public double Nota1
        {
            get => _nota;
            set => _nota = FiltrandoNota(value);
        }

        //Propiedad Automatica
        /*Esta propiedad no nesecita que nostros creemos una variable privada*/
        public double Nota2 { get; set; }

        public Alumno(double nota)
        {
            _nota = nota;
        }

        public double FiltrandoNota(double nota)
        {
            if (nota < 0) return 0;
            else return nota;
        }
        /*
        public void SetNota(double nota)
        {
            //ESTAMOs filtrando o controlando el valor que esta manejando 
            if (_nota < 0) _nota = 0;
            else _nota = nota;
        }
        public double GetNota()
        {
            return _nota;
        }*/
    }
}
