using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueseria
{
    internal class Complemento : Producto
    {
        public Complemento() { }

    }

    internal class Patatas : Complemento
    {
        public Patatas() { }
    }

    internal class Nuggets : Complemento
    {
        public const int CANTIDAD_PEQUENIA = 6;
        public const int CANTIDAD_MEDIANA = 9;
        public const int CANTIDAD_GRANDE = 12;
        private int cantidad; 
        public Nuggets() { 
            this.cantidad = CantidadNuggets(); 
        }

        private int CantidadNuggets()
        {
            Console.WriteLine("Elige cantidad nuggets:");
            Console.WriteLine("Selección S = 6 nuggets");
            Console.WriteLine("Selección M = 9 nuggets");
            Console.WriteLine("Selección L = 12 nuggets");

            char eleccion = Convert.ToChar(Console.ReadLine().ToUpper());

            if (eleccion == Tamanios.TAMANIO_PEQUENIO) return CANTIDAD_PEQUENIA;
            if (eleccion == Tamanios.TAMANIO_MEDIANO) return CANTIDAD_MEDIANA;
            if (eleccion == Tamanios.TAMANIO_GRANDE) return CANTIDAD_GRANDE;
        }
    }
}
