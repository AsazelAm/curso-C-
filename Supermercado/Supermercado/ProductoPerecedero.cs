using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    internal class ProductoPerecedero:Producto
    {
        //DateTime:es una clase que nos permite manejar el tiempo
        public DateTime FechaVencimiento { get; set; }//Para ocuparlo por es un metodo tenemos que instanciar este objeto de esta clase

        //Constructor
        public ProductoPerecedero(string nombre, string codigo, double precio, DateTime fechaVencimiento)
            :base(nombre,codigo, precio)
        {
            FechaVencimiento = fechaVencimiento;
        }
        public override void DescontandoProducto()
        {
            double descuento = Precio * 0.02;
            //base.DescontandoProducto();
            Console.WriteLine("Los productos perecederos tienen un 2% de Descuento");
            Console.WriteLine("EL descuento de este producto es de {0}", descuento);
            Precio -= descuento;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();/*cuando ocupamos base dentro de un metodo nos permitellamar al metodo MostrarInfo de la clase Padre */
            Console.WriteLine("Fecha de Vencimiento {0}\n", FechaVencimiento);
        }
    }
}
