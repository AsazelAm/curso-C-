using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPOO
{
    /*La forma de heredar de la clase Padre o clase Base 
     nombreDeLaClaseDerrivada: nombreDeLaClaseBase
     */
    internal class Perro:Mascota //se hereda de la clase padre con 2 puntos de forma interna ya los herredo los metodos y las variables
    {
        //Agregamos sus propios metodos
        //Si tenemos una variable en la clase hija lo podemos inicializar normalmente en el constructor hijo
        private string _color;

        //para llamar el constructor de la clase padre nosotros debemos tambien colocar los mismos parametros
        //Es un requisito obligatorio llamar al cosntructor al tener un constructor en la clase padre
        //Debemos crear al constructor hijo y luego llamar al constructor padre se debe pasar el mismo orden de los parametros 
        //La palabra base hace Referencia al constructor de la clase Mascota
        public Perro(int patas, bool tienePatas, bool tienePelajes, string color):base(patas, tienePatas, tienePelajes)
        {
            _color = color;

        }
        public void Ladrar()
        {
            Console.WriteLine("El perro ladra");
            //Console.WriteLine(_patas);//Nos deja acceder a la variable protected solo se ocupa cuando sea meramente nesesario
        }
        public string MostrarInfo()
        {
            return "El perro tiene: " + GetPatas() + " patas y un color: " + _color  ;
        }

    }
}
