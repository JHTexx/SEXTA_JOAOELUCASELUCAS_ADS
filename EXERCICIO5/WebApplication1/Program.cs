using System;
using System.Text;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra ou frase:");
        string entrada = Console.ReadLine();

        if (EhPalindromo(entrada))
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
    }

    static bool EhPalindromo(string texto)
    {
        // Remove espaços, acentos e coloca tudo em minúsculo
        texto = RemoverAcentos(texto).ToLower();
        texto = texto.Replace(" ", "");

        // Inverter o texto
        char[] arrayTexto = texto.ToCharArray();
        Array.Reverse(arrayTexto);
        string textoInvertido = new string(arrayTexto);

        // Verificar se é igual
        return texto == textoInvertido;
    }

    static string RemoverAcentos(string texto)
    {
        StringBuilder textoSemAcento = new StringBuilder();
        var textoNormalizado = texto.Normalize(NormalizationForm.FormD);

        foreach (char c in textoNormalizado)
        {
            UnicodeCategory categoria = CharUnicodeInfo.GetUnicodeCategory(c);
            if (categoria != UnicodeCategory.NonSpacingMark)
            {
                textoSemAcento.Append(c);
            }
        }

        return textoSemAcento.ToString().Normalize(NormalizationForm.FormC);
    }
}
