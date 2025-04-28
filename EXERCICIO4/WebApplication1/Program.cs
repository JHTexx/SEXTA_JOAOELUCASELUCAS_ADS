using System;

class Program
{
    static void Main()
    {
        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("\n=== Conversor de Temperaturas ===");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a temperatura em Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
                    break;

                case 2:
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
                    break;

                case 3:
                    Console.WriteLine("Saindo do programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}
