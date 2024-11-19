using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueseria
{
    //Clase Hamburguesa
    class Hamburguesa : Producto
    {
        public int cantidadCarne { get; set; }
        public int cantidadQueso { get; set; }
        public bool pepinillo { get; set; }

        public Hamburguesa()
        {
            nombreProducto = "Hamburguesa";
            precioProducto = 5.0; //precio base
        }

        //método para elegir los ingredientes
        public void ElegirIngredientes()
        {
            //elegir cantidad de carne con validación
            Console.WriteLine("Elige la cantidad de carne (1, 2 o 3):");
            cantidadCarne = int.Parse(Console.ReadLine());
            
            //validar que la cantidad de carne esté entre 1, 2 o 3
            if (cantidadCarne < 1 || cantidadCarne > 3)
            {
                Console.WriteLine("Cantidad de carne no válida, se seleccionará 1 por defecto.");
                cantidadCarne = 1; //por defecto se selecciona 1
            }
            
            //elegir cantidad de queso
            Console.WriteLine("Elige la cantidad de queso (en rebanadas):");
            cantidadQueso = int.Parse(Console.ReadLine());
            if (cantidadQueso < 0) 
            {
                Console.WriteLine("Entrada no válida para queso, se seleccionará 0 por defecto.");
                cantidadQueso = 0; //si es negativo, por defecto será 0
            }

            // elegir si quiere pepinillo
            Console.WriteLine("¿Quieres pepinillo? (si/no):");
            string inputPepinillo = Console.ReadLine().ToUpper();
            pepinillo = inputPepinillo == "SI";
        }

        //método para calcular el precio final de la hamburguesa
        public override double CalcularPrecio()
        {
            double precioFinal = precioProducto;
            precioFinal += cantidadCarne * 3.5; //precio adicional por carne
            precioFinal += cantidadQueso * 0.30; //precio adicional por queso
            return precioFinal;
        }

        //método para mostrar los detalles de la hamburguesa
        public override string VerDetalles()
        {
            return $"Hamburguesa con {cantidadCarne} de carne, {cantidadQueso} rebanadas de queso y " +
                   (pepinillo ? "con pepinillo." : "sin pepinillo.") + $" Precio: {CalcularPrecio()} euros.";
        }
    }
}
