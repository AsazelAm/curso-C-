using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetters
{
    internal class Pelota
    {
        //Atributos
        private double _pesoGramos;
        private string _color;
        
        //Constructor por defecto
        public Pelota()
        {
            _pesoGramos = 150;
            _color = "Blanca";
        }

        //mETODO Setters:nos permite establecer el valor a un parametro
        public void SetPeso(double peso)
        {
            _pesoGramos = peso;
        }
        //metodo Getter: permite obtener el valor de la variable regresar el valor de un parametro
        public double GetPeso()
        {
            return _pesoGramos;
        }
        public void SetColor(string color)
        {
            _color = color;
        }
        public string GetColor()
        {
            return _color;
        }
        public void MostrarInfoPelota()
        {
            Console.WriteLine("Peso: " + _pesoGramos + " Color: " + _color);
        }
    }
}
