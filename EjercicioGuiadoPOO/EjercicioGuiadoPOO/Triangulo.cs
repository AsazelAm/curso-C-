using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuiadoPOO
{
    internal class Triangulo
    {
        //Colocamos los atributos o los campos de Clases
        private double _lado;
        private double _base;//Si no se coloca el valor de la base por defecto es 0
        private double _altura;

        //Cramos dos cotructores
        //Constructor triangulo equilater
        public Triangulo (double lado)
        {
            _lado = lado;
        }

        //Constructor pra triangulo Isoceles
        public Triangulo(double lado, double bas)
        {
            _lado = lado;
            _base = bas;
        }
        
        //Getter Altura
        public double GetAltura()
        {
            return _altura;
        }
        public double GetLado()
        {
            return _lado;
        }
        public double GetBase()
        {
            return _base;
        }

        //Metodos para calcular
        public double CalcularPerimetro()
        {
            double perimetro = 0;
            if (_base == 0)//significa q estamos trabajando es el constructo equilatero
            {
                perimetro  = _lado * 3;
            }
            else //si es tiene valor la vase significa que utilizamos el constructor Isoceles
            {
                perimetro = (_lado * 2) + _base;
            }
            return perimetro;
        }
        //Calcular area del triangulo
        public void CalcularAltura()
        {
            //La clase Math es estatica no le instanciamos un objetos tranquilamente podemos ocupar los metodos
            /*double hipotenusaAlCuadrado = Math.Pow(_lado, 2);//ocupar el Metodo Pow de la clase Math ---- Pow para elevarlo a la potencia
            double catetoInferior = Math.Pow(_lado / 2, 2);
            altura = Math.Sqrt(hipotenusaAlCuadrado - catetoInferior);//Devuelve la raiz cuadrada
            */
            //Forma directa
            if(_base == 0)_altura = Math.Sqrt(Math.Pow(_lado, 2) - Math.Pow(_lado / 2, 2));
            else _altura = Math.Sqrt(Math.Pow(_lado, 2) - Math.Pow(_base / 2, 2));
        }
        public double CalcularArea()
        {
            //A = (b * h)/ 2;
            double area = 0;
            if (_base == 0) area = (_lado * _altura) / 2;
            else area = (_base * _altura) / 2;
            return area;
        }
    }
}
