internal class Program
{
    private const string ARCHIVO_RUTA = ".\\archivo.txt";

    private static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\nElige opción:");
            Console.WriteLine("1 - Escribir archivo" +
                "\n2 - Agregar texto al archivo" +
                "\n3 - Mostrar contenido del archivo " +
                "\n0 - Salir");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        EscribirArchivoCompleto(ARCHIVO_RUTA);
                        break;
                    case 2:
                        AgregarTextoAlFinal(ARCHIVO_RUTA);
                        break;
                    case 3: 
                        LeerArchivo(ARCHIVO_RUTA);
                        break;
                    case 0:
                        Console.WriteLine("Hasta luego...");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }
        }
    }

    private static void EscribirArchivoCompleto(string ruta)
    {
        Console.Write("Escribe el contenido que quieres guardar en el archivo: ");
        string contenido = Console.ReadLine();
        File.WriteAllText(ruta, contenido);
        Console.WriteLine("Contenido guardado.");
    }

    private static void AgregarTextoAlFinal(string ruta)
    {
        Console.Write("Escribe el texto que deseas agregar al archivo: ");
        string texto = Console.ReadLine();

        if (File.Exists(ruta))
        {
            File.AppendAllText(ruta, Environment.NewLine + texto);
            Console.WriteLine("Texto agregado al final del archivo.");
        }
        else
        {
            Console.WriteLine("El archivo no existe. Se creará un nuevo archivo.");
            File.WriteAllText(ruta, texto);
        }
    }

    private static void LeerArchivo(string ruta)
    { 
        string contenido = File.ReadAllText(ruta);
        Console.WriteLine($"Contenido del archivo: \n{contenido}");
    }

}
