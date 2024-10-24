internal class Program
{
    private static void Main(string[] args)
    {
        string[] listaDePalabras = { "programacion", "computadora", "juego", "desarrollador", "tecnologia" };
        int intentos = 3;
        bool acierto = false;

        string palabraReto = eleccionPalabra(listaDePalabras);
        string palabraRetoDesordenada = desordenarPalabra(palabraReto);

        Console.WriteLine($"Adivina la palabra: {palabraRetoDesordenada}");

        do
        {
            string palabraIntento = Console.ReadLine();
            if (palabraIntento.Equals(palabraReto))
            {
                Console.WriteLine("Acertaste!");
                acierto = true;
            }
            else
            {
                --intentos;
                Console.Write("No es así, intentalo otra vez, le quedan ");
                Console.WriteLine(intentos != 1 ? intentos + " intentos." : intentos + " intento.");
            }
        }
        while (intentos != 0 || acierto);

    }

    private static string eleccionPalabra(string[] listaPalabras) 
    { 
        Random random = new Random();

        string palabraElegida = listaPalabras[random.Next(listaPalabras.Length - 1)];

        return palabraElegida;
    }

    private static string desordenarPalabra(string input)
{
    char[] chars = input.ToCharArray();
    Random random = new Random();

    for (int i = chars.Length - 1; i > 0; i--)
    {
        int j = random.Next(i + 1);
        intercambio(chars, i, j);
    }

    return new string(chars);
}

    private static void intercambio(char[] array, int i, int j)
    {
        char temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }


}