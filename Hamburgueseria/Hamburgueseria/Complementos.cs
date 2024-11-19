using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueseria
{
    //Clase Complemento
    class Complemento : Producto
    {
        public string tipoComplemento { get; set; }
        public char tamanio { get; set; }

        public Complemento()
        {
            nombreProducto = "Complemento";
            tipoComplemento = ElegirTipoComplemento();
            tamanio = ElegirTamanio();
            precioProducto = CalcularPrecio();
        }

        public string ElegirTipoComplemento()
        {
            Console.WriteLine("Elige complemento: patatas o nuggets");
            tipoComplemento = Console.ReadLine().ToUpper();

            //verificar si el complemento elegido es válido
            if (tipoComplemento != "PATATAS" && tipoComplemento != "NUGGETS")
            {
                Console.WriteLine("Complemento no válido, se seleccionarán patatas por defecto.");
                tipoComplemento = "PATATAS"; //por defecto seleccionamos Patatas
            }

            return tipoComplemento;
        }

        public char ElegirTamanio()
        {
            Console.WriteLine("Elige tamaño (S = Pequeño, M = Mediano, L = Grande):");
            char tamanio = Char.ToUpper(Console.ReadLine()[0]);

            //verificar si el tamaño es válido, si no fuera se seleccionará 'M' por defecto
            if (tamanio != 'S' && tamanio != 'M' && tamanio != 'L')
            {
                Console.WriteLine("Tamaño no válido, se seleccionará tamaño Mediano (M) por defecto.");
                tamanio = 'M'; //por defecto M
            }

            return tamanio;
        }

        public override double CalcularPrecio()
        {
            double precio = 0;

            //precios según el tipo de complemento y tamaño
            if (tipoComplemento == "PATATAS")
            {
                precio = tamanio == 'S' ? 3.0 : tamanio == 'M' ? 4.0 : 5.0;
            }
            else if (tipoComplemento == "NUGGETS")
            {
                precio = tamanio == 'S' ? 3.0 : tamanio == 'M' ? 4.0 : 5.0;
            }

            return precio;
        }

        public override string VerDetalles()
        {
            return $"{tipoComplemento} ({tamanio}) - Precio: {CalcularPrecio()} euros.";
        }
    }
}
