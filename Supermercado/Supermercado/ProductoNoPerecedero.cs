using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    internal class ProductoNoPerecedero:Producto
    {
        public string Tipo { get; set; }
        public ProductoNoPerecedero(string nombre, string codigo, double precio, string tipo)
           : base(nombre, codigo, precio)
        {
            Tipo = tipo;
        }
        public override void DescontandoProducto()
        {
            double descuento = Precio * 0.03;
           // base.DescontandoProducto();
            Console.WriteLine("Los productos perecederos tienen un 3% de Descuento");
            Console.WriteLine("EL descuento de este producto es de {0}", descuento);
            Precio -= descuento;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();/*cuando ocupamos base dentro de un metodo nos permitellamar al metodo MostrarInfo de la clase Padre */
            Console.WriteLine("Tipo de producto no perecedero {0}\n", Tipo);
        }
    }
}
