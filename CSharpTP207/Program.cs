using System;

namespace CSharpTP207;

class Program
{
    static void Main()
    {
        int numero = LerNumero();

        string resultado = VerificarParidade(numero);

        ExibirResultado(numero, resultado);
    }

    static int LerNumero()
    {
        Console.Write("Digite um número inteiro: ");

        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Número inválido. Tente novamente.");
            Console.Write("Digite um número inteiro: ");
        }

        return numero;
    }

    static string VerificarParidade(int numero)
    {
        if (numero % 2 == 0)
        {
            return "Par";
        }

        return "Ímpar";
    }

    static void ExibirResultado(int numero, string resultado)
    {
        Console.WriteLine();
        Console.WriteLine("===== RESULTADO =====");
        Console.WriteLine($"Número: {numero}");
        Console.WriteLine($"Classificação: {resultado}");
    }
}