using System;
using System.Collections.Generic;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>();

        Console.WriteLine("Cadastro de 3 produtos:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nProduto {i + 1}:");

            Produto produto = new Produto();

            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            produtos.Add(produto);
        }

        Console.WriteLine("\n=== Lista de Produtos Cadastrados ===");

        foreach (var p in produtos)
        {
            Console.WriteLine($"Nome: {p.Nome}");
            Console.WriteLine($"Preço: R$ {p.Preco:F2}");
            Console.WriteLine($"Quantidade: {p.Quantidade}");
            Console.WriteLine($"Valor Total em Estoque: R$ {p.ValorTotalEmEstoque():F2}\n");
        }
    }
}

