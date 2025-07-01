using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    internal class Producto
    {
        //GetSet
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public double Precio { get; set; }

        //Constructor
        public Producto(string nombre, string codigo, double precio)
        {
            this.Nombre = nombre;
            this.Codigo = codigo;
            this.Precio = precio;
        }
        public virtual void DescontandoProducto()
        {
            Console.WriteLine("Descontando el precion del siguiente producto");
        }

        //SobreEscribimos el metodo
        public virtual void MostrarInfo()
        {
            Console.WriteLine("Nombre: {0}, codigo: {1}, Precio: {2}", Nombre, Codigo, Precio);
        }
    }
}
