using System;

namespace CSharpTP211;

class Program
{
    static void Main()
    {
        int numero = LerNumero();

        string tabuada = GerarTabuada(numero);

        ExibirResultado(tabuada);
    }

    static int LerNumero()
    {
        Console.Write("Digite um número para a tabuada: ");

        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Número inválido. Tente novamente.");
            Console.Write("Digite um número para a tabuada: ");
        }

        return numero;
    }

    static string GerarTabuada(int numero)
    {
        string resultado = "";

        for (int i = 1; i <= 10; i++)
        {
            resultado += $"{numero} x {i} = {numero * i}";

            if (i < 10)
            {
                resultado += Environment.NewLine;
            }
        }

        return resultado;
    }

    static void ExibirResultado(string tabuada)
    {
        Console.WriteLine();

        Console.WriteLine("===== TABUADA =====");
        Console.WriteLine(tabuada);
    }
}