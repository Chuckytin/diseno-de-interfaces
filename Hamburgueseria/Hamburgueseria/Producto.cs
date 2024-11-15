using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueseria
{
    //Clase abstracta Producto
    abstract class Producto
    {
        public string nombreProducto { get; set; }
        public double precioProducto { get; set; }

        public abstract double CalcularPrecio();
        public abstract string VerDetalles();
    }
}