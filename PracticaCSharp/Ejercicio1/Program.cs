using System.Collections.Immutable;

internal class Program
{
    private static void Main(string[] args)
    {
        solicitarNumeros();
    }

    /* Pedir al usuario que introduzca 3 números por pantalla, una vez introducidos,
   mostrar por pantalla los números ordenados de menor a mayor. */
    private static void solicitarNumeros()
    { 
        Console.WriteLine("Introduzca 3 números para ordenarlos de menor a mayor: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Los números ordenados son: ");

        ordenarNumeros(num1, num2, num3);

        ordenarPorArray(num1, num2, num3);

    }

    private static void ordenarNumeros(int num1, int num2, int num3) 
    {
        int numMayor = 0, numMediano = 0, numMenor = 0;

        if (num1 > num2 && num1 > num3)
        {
            numMayor = num1;
            if (num2 > num3)
            {
                numMediano = num2;
                numMenor = num3;
            } else
            {
                numMediano = num3;
                numMenor = num2;
            }

        }

        if (num3 > num2 && num3 > num1)
        {
            numMayor = num3;
            if (num2 > num1)
            {
                numMediano = num2;
                numMenor = num1;
            }
            else {
                numMediano = num1;
                numMenor = num2;
            }
        }

        if (num2 > num1 && num2 > num3)
        {
            numMayor = num2;
            if (num3 > num1)
            {
                numMediano = num3;
                numMenor = num1;
            }
            else
            {
                numMediano = num1;
                numMenor = num3;
            }
        }

        Console.WriteLine(String.Format("{0} < {1} < {2}", numMenor, numMediano, numMayor));

    }

    private static void ordenarPorArray(int num1, int num2, int num3) 
    {

        int [] numArray = { num1, num2, num3 };

        Array.Sort(numArray);

        foreach (int e in numArray) {
            Console.Write(e + " ");
        }
    }
}