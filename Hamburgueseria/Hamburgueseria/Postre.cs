using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Hamburgueseria
{
    internal class Postre : Producto
    {
        public double precioBase = 1.0d;
        
        public Postre()
        { 
            this.precioProducto = precioBase;
        }

        public override string ToString() 
        {
            return "Precio: " + this.precioProducto + ((precioProducto == 1) ? " euro" : " euros");
        }

    }

    internal class Helado : Postre
    {
        public char tamanioHelado;

        public const double SUPLEMENTO_MEDIANO = 1.50d;
        public const double SUPLEMENTO_GRANDE = 2.0d;

        public Helado() : base()
        {
            this.tamanioHelado = EleccionTamanio();
            TamanioPrecio();

        }

        private char EleccionTamanio() {

            Console.WriteLine("Tamaños del Helado: S, M, L");
            char eleccion = Convert.ToChar(Console.ReadLine().ToUpper());

            if (eleccion == Tamanios.TAMANIO_PEQUENIO || 
                eleccion == Tamanios.TAMANIO_MEDIANO || 
                eleccion == Tamanios.TAMANIO_GRANDE) 
            {
                return eleccion;
            }
            else
            {
                return Tamanios.TAMANIO_MEDIANO; //por defecto
            }

        }

        private void TamanioPrecio()
        {
            if (tamanioHelado == Tamanios.TAMANIO_MEDIANO) { this.precioProducto *= SUPLEMENTO_MEDIANO; }

            if (tamanioHelado == Tamanios.TAMANIO_GRANDE) { this.precioProducto *= SUPLEMENTO_GRANDE; }
        }

        public override string ToString()
        { 
            return "Helado " + base.ToString() + ", Tamaño: " + tamanioHelado;
        }
    }
    
    internal class Manzana : Postre 
    {
        public Manzana() { }

        public override string ToString()
        {
            return "Manzana " + base.ToString();
        }

    }
}
