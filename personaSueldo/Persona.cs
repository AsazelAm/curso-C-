using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personaSueldo
{
    internal class Persona
    {
        protected string Nombre;
        protected string Apellido;
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }


    }
    class Empleado : Persona
    {
        public double Sueldo {  get; set; }
        public Empleado(string nombre, string apellido,double sueldo) : base(nombre,apellido)
        {
            Sueldo = sueldo;   
        }
        public void mostrarDato() 
        {
            Console.WriteLine($"Nombre: {Nombre} \tApellido: {Apellido}\tSueldo: {Sueldo}");
        }
    } 
}
