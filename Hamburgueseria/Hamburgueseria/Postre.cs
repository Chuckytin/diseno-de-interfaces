using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueseria
{
    //Clase Postre
    class Postre : Producto
    {
        public string tipoPostre { get; set; }

        public Postre()
        {
            nombreProducto = "Postre";
            tipoPostre = ElegirPostre();
            precioProducto = CalcularPrecio();
        }

        //método para elegir el postre
        public string ElegirPostre()
        {
            Console.WriteLine("Elige un postre: Helado o Manzana");
            tipoPostre = Console.ReadLine().ToUpper();

            //validar si el postre elegido es correcto
            if (tipoPostre != "HELADO" && tipoPostre != "MANZANA")
            {
                Console.WriteLine("Postre no válido, se seleccionará Manzana por defecto.");
                tipoPostre = "MANZANA"; //si no es válido, se selecciona "Manzana" por defecto
            }

            return tipoPostre;
        }

        //método para calcular el precio del postre
        public override double CalcularPrecio()
        {
            return tipoPostre == "HELADO" ? 3.0 : 1.0; //3.0€ por Helado y 1.0€ por Manzana
        }

        //método para ver los detalles del postre
        public override string VerDetalles()
        {
            return $"{tipoPostre} - Precio: {CalcularPrecio()} euros.";
        }
    }
}
