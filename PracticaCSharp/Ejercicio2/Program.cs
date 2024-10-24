using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        solicitudArea();
    }

    /*El programa devolverá el área de un círculo, un cuadrado o un triángulo.Para ello se
solicitará al usuario los datos necesarios por consola. Utilizar una estructura switch
donde los case sean los tipos de figura.
Area_circulo= Pi x r^2
Area_cuadrado= b x h
Area_triangulo= b x h/2
    */

    private static void solicitudArea() {

        bool salir = false;

        while (!salir) {

            Console.WriteLine("Solicita el área que deseas calcular: ");
            Console.WriteLine("1 - Círculo \n2 - Cuadrado \n3 - Triángulo \n4 - Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    circulo();
                    break;
                case 2:
                    cuadrado();
                    break;
                case 3:
                    triangulo();
                    break;
                case 4:
                    Console.WriteLine("Hasta luego...");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida!");
                    break;
            }
        }

        
    }

    private static void circulo() {

        const double PI = 3.14;

        Console.WriteLine("Introduce el rádio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double resultado = PI * (radio * radio);

        Console.WriteLine("Área del círculo: " + resultado);

    }

    private static void cuadrado() {

        Console.WriteLine("Introduce el lado del cuadrado: ");
        double lado = Convert.ToDouble(Console.ReadLine());

        double resultado = lado * lado;

        Console.WriteLine("Área del cuadrado: " + resultado);

    }

    private static void triangulo() {

        Console.WriteLine("Introduce la base del triángulo: ");
        double basee = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introduce la altura del triángulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double resultado = basee * altura / 2;

        Console.WriteLine("Área del triángulo: " + resultado);
    }

}