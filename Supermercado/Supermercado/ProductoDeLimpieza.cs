using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    internal class ProductoDeLimpieza:Producto
    {
        public string IngredienteProducto { get; set; }
        public ProductoDeLimpieza(string nombre, string codigo, double precio, string ingredienteProducto)
           : base(nombre, codigo, precio)
        {
            IngredienteProducto = ingredienteProducto;
        }
        public override void DescontandoProducto()
        {
            double descuento = Precio * 0.01;
            //base.DescontandoProducto();
            Console.WriteLine("Los productos perecederos tienen un 1% de Descuento");
            Console.WriteLine("EL descuento de este producto es de {0}", descuento);
            Precio -= descuento;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();/*cuando ocupamos base dentro de un metodo nos permitellamar al metodo MostrarInfo de la clase Padre */
            Console.WriteLine("Ingrediente del producto Limpieza {0}\n", IngredienteProducto);
        }
    }
}
