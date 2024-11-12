using Hamburgueseria;

internal class Program
{
    private static void Main(string[] args)
    {
        Manzana m = new Manzana();
        Helado h1 = new Helado();
        Helado h2 = new Helado();

        Console.WriteLine(m + "\n" + h1 + "\n" + h2);

    }
}