using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        List<bool> tarefasConcluidas = new List<bool>();

        int opcao = 0;

        do
        {
            Console.WriteLine("\n=== Lista de Tarefas ===");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Marcar tarefa como concluída");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a nova tarefa: ");
                    string novaTarefa = Console.ReadLine();
                    tarefas.Add(novaTarefa);
                    tarefasConcluidas.Add(false);
                    Console.WriteLine("Tarefa adicionada!");
                    break;

                case 2:
                    Console.WriteLine("\nTarefas:");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        string status = tarefasConcluidas[i] ? "[Concluída]" : "[Pendente]";
                        Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                    }
                    break;

                case 3:
                    Console.WriteLine("\nDigite o número da tarefa para marcar como concluída:");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        string status = tarefasConcluidas[i] ? "[Concluída]" : "[Pendente]";
                        Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                    }

                    int numero = int.Parse(Console.ReadLine());
                    if (numero >= 1 && numero <= tarefas.Count)
                    {
                        tarefasConcluidas[numero - 1] = true;
                        Console.WriteLine("Tarefa marcada como concluída!");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saindo da lista de tarefas...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

        } while (opcao != 4);
    }
}
