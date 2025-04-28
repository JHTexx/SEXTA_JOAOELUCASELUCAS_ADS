using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite sua senha:");
        string senha = Console.ReadLine();

        if (SenhaValida(senha))
        {
            Console.WriteLine("Senha forte!");
        }
        else
        {
            Console.WriteLine("Senha inválida! Ela deve conter:");
            Console.WriteLine("- Pelo menos 8 caracteres");
            Console.WriteLine("- Pelo menos uma letra maiúscula");
            Console.WriteLine("- Pelo menos um número");
            Console.WriteLine("- Pelo menos um caractere especial (!, @, #, etc.)");
        }
    }

    static bool SenhaValida(string senha)
    {
        if (senha.Length < 8)
            return false;

        if (!Regex.IsMatch(senha, "[A-Z]"))
            return false;

        if (!Regex.IsMatch(senha, "[0-9]"))
            return false;

        if (!Regex.IsMatch(senha, "[!@#\\$%\\^&\\*\\(\\)_\\+\\-=\\[\\]\\{\\};:'\",<.>/?]"))
            return false;

        return true;
    }
}

