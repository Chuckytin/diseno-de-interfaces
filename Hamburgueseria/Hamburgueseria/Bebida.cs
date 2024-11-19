using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueseria
{
    // Clase Bebida
    class Bebida : Producto
    {
        public string tipoBebida { get; set; }
        public char tamanio { get; set; }

        public Bebida()
        {
            nombreProducto = "Bebida";
            tipoBebida = ElegirBebida();
            tamanio = ElegirTamanio();
            precioProducto = CalcularPrecio();
        }

        //método para elegir la bebida
        public string ElegirBebida()
        {
            Console.WriteLine("Elige una bebida: agua, coca cola o fanta");
            tipoBebida = Console.ReadLine().ToUpper();

            //validar si la bebida elegida es correcta
            if (tipoBebida != "AGUA" && tipoBebida != "COCA COLA" && tipoBebida != "FANTA")
            {
                Console.WriteLine("Bebida no válida, se seleccionará agua por defecto.");
                tipoBebida = "AGUA"; //si no es válida, se selecciona "AGUA" por defecto
            }

            return tipoBebida;
        }

        //método para elegir el tamaño de la bebida
        public char ElegirTamanio()
        {
            Console.WriteLine("Elige tamaño (S = Pequeño, M = Mediano, L = Grande):");
            char tamanioElegido = Char.ToUpper(Console.ReadLine()[0]);

            //validar tamaño
            if (tamanioElegido != 'S' && tamanioElegido != 'M' && tamanioElegido != 'L')
            {
                Console.WriteLine("Tamaño no válido, se seleccionará tamaño Mediano (M) por defecto.");
                tamanioElegido = 'M'; //si no es válido, se selecciona "M" por defecto
            }

            return tamanioElegido;
        }

        //método para calcular el precio de la bebida según el tipo y tamaño
        public override double CalcularPrecio()
        {
            double precio = 0;

            //precio base según la bebida
            switch (tipoBebida)
            {
                case "AGUA":
                    precio = 1.0;
                    break;
                case "COCA COLA":
                case "FANTA":
                    precio = 1.5;
                    break;
            }

            //incremento de precio por tamaño
            if (tamanio == 'M') precio += 0.5;
            if (tamanio == 'L') precio += 1.0;

            return precio;
        }

        //método para mostrar los detalles de la bebida
        public override string VerDetalles()
        {
            return $"{tipoBebida} ({tamanio}) - Precio: {CalcularPrecio()} euros.";
        }
    }
}
