using _20250218_HamVecino_DI_Angel_Torcal;
using System;
using System.Windows;

public class Program
{
    /*
    static void Main(string[] args)
    {
        //Instanciamos clases
        Pedido pedido = new Pedido();
        Carta carta = new Carta();

        //Cargamos carta
        carta.cargarCarta(pedido);

        //Variables 
        int opcion = -1;


        do
        {
            Console.WriteLine("---------Hamburgueseria----------");
            Console.WriteLine("1. Hamburguesas");
            Console.WriteLine("2. Patatas");
            Console.WriteLine("3. Bebidas");
            Console.WriteLine("4. Nuggets");
            Console.WriteLine("5. Postre");
            Console.WriteLine("6. Ver pedido");
            Console.WriteLine("7. Borrar pedido");
            Console.WriteLine("8. Confirmar pedido");
            Console.WriteLine("0. Salir");
            Console.WriteLine("---------------------------------");
            Console.Write("Introduzca una opcion: ");

            //Abrimos un try-catch para capturar todas las opciones no validas de las selecciones
            try
            {
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        pedido.mostrarHamburguesas();
                        break;
                    case 2:
                        pedido.mostrarPatatas();
                        break;
                    case 3:
                        pedido.mostrarBebidas();
                        break;
                    case 4:
                        pedido.mostrarNuggets();
                        break;
                    case 5:
                        pedido.mostrarPostres();
                        break;
                    case 6:
                        pedido.mostrarPedido();
                        break;
                    case 7:
                        pedido.borrarPedido();
                        break;
                    case 8:
                        pedido.confirmarPedido();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del sistema ...");
                        break;
                    default:
                        Console.WriteLine("Introduzca una opcion válida!");
                        break;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Introduzca una opcion válida!");
            }
        } while (opcion != 0);

    }
    */
}
