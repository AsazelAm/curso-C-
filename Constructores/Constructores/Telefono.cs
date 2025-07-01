using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class Telefono
    {
        //por buena practica las variables de tipo modificador de acceso private se coloca la barraDEAbajo 
        //atributos dela clase
        private int _memoria;
        private int _ram;
        private double _peso;
        private int _megapixeles;
        private bool _tieneFlashFrontal;

        //Constructor
        //El nombre del constructor siempre tiene que ser el nombre de la clase
        //para crear el constructor se colaca la palabra reservada public y el nombre de la clase
        public Telefono()//El constructor que no tiene parametros se lo conoce como Constructor Por Defecto 
        {
            //inicializamos el objeto dando el valor por defecto a cada una de las variables que hemos creado
            _memoria = 128;
            _ram = 6;
            _peso = 150;
            _megapixeles = 20;
            _tieneFlashFrontal = false;
            /*Valor por defectos de los campos de clases osea atributos
             * _memoria = 0;
            _ram = 0;
            _peso = 0;
            _megapixeles = ;
            _tieneFlashFrontal = false;*/
        }
        //Sobrecarga de Metodos
        //Es similar ala sobrecarga de metodos se puede ocupar el mistmo metodo pero esta es com parrametros
        public Telefono(int memoria, int ram, double peso, int megapixeles, bool tieneFlashFrontal)
        {
            //this._memoria = memoria; this nos trata de decir que este atributo pertenece a esta clase 
            _memoria = memoria;
            _ram = ram;
            _peso = peso;
            _megapixeles = megapixeles;
            _tieneFlashFrontal=tieneFlashFrontal;
        }
        public int ObtenerMemoria()
        {
            return _memoria;
        }
    }
}
