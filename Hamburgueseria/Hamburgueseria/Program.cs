using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueseria
{
    //Clase principal Program
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                MostrarMenu();
                string opcion = Console.ReadLine().ToUpper();

                switch (opcion)
                {
                    case "1":
                        //crear y elegir una hamburguesa
                        Hamburguesa hamburguesa = new Hamburguesa();
                        hamburguesa.ElegirIngredientes();
                        Console.WriteLine(hamburguesa.VerDetalles());
                        break;

                    case "2":
                        //crear y elegir una bebida
                        Bebida bebida = new Bebida();
                        Console.WriteLine(bebida.VerDetalles());
                        break;

                    case "3":
                        //crear y elegir un complemento
                        Complemento complemento = new Complemento();
                        Console.WriteLine(complemento.VerDetalles());
                        break;

                    case "4":
                        //crear y elegir un postre
                        Postre postre = new Postre();
                        Console.WriteLine(postre.VerDetalles());
                        break;

                    case "5":
                        //menú completo
                        hamburguesa = new Hamburguesa();
                        hamburguesa.ElegirIngredientes();
                        bebida = new Bebida();
                        complemento = new Complemento();
                        postre = new Postre();

                        double precioTotal = hamburguesa.CalcularPrecio() + bebida.CalcularPrecio() + complemento.CalcularPrecio() + postre.CalcularPrecio();
                        Console.WriteLine("\n****************************************************");
                        Console.WriteLine("\nDetalles del pedido:");
                        Console.WriteLine(hamburguesa.VerDetalles());
                        Console.WriteLine(bebida.VerDetalles());
                        Console.WriteLine(complemento.VerDetalles());
                        Console.WriteLine(postre.VerDetalles());
                        Console.WriteLine($"El precio total del pedido es: {precioTotal} euros.\n");
                        Console.WriteLine("****************************************************");
                        break;

                    case "6":
                        //salir del programa
                        Console.WriteLine("¡Hasta pronto!");
                        return;

                    default:
                        Console.WriteLine("Opción no válida, por favor selecciona una opción válida.");
                        break;
                }

                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("¡Bienvenido a nuestra Hamburguesería!");
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1. Elegir Hamburguesa");
            Console.WriteLine("2. Elegir Bebida");
            Console.WriteLine("3. Elegir Complemento");
            Console.WriteLine("4. Elegir Postre");
            Console.WriteLine("5. Ver Menú Completo");
            Console.WriteLine("6. Salir");
            Console.Write("Opción: ");
        }
    }
}
