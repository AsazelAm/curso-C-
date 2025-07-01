using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto[] productosSupermecado = new Producto[6];

            productosSupermecado[0] = new ProductoDeLimpieza("Jabon","023s3",2,"Coco");
            productosSupermecado[1] = new ProductoNoPerecedero("Arroz","02",1.5,"Grano");
            productosSupermecado[2] = new ProductoPerecedero("Leche", "242k", 1.2, new DateTime(2024, 09, 12));//Haca lo creamos y la instanciamo
            //DateTime()  podemos indicar la fecha año mes y dia
            productosSupermecado[3] = new ProductoPerecedero("Leche","004",1.2,new DateTime(2024,10,01));
            productosSupermecado[4] = new ProductoNoPerecedero("Sopa Enlatada","005",3,"Enlatados");
            productosSupermecado[5] = new ProductoDeLimpieza("Detergente","006",2.7,"Sulfato de Sodio");

            for(int i=0; i<productosSupermecado.Length; i++)
            {
                productosSupermecado[i].DescontandoProducto();
                productosSupermecado[i].MostrarInfo();
            }


        }
    }
}
