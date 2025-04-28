using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int somaPares = 0;

        Console.WriteLine("Digite 10 números:");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                somaPares += numeros[i];
            }
        }

        Console.WriteLine($"\nA soma dos números pares é: {somaPares}");
    }
}
