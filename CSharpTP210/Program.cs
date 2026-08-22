using System;

namespace CSharpTP210;

class Program
{
    static void Main()
    {
        int numeroInicial = LerNumeroInicial();

        string contagem = GerarContagemRegressiva(numeroInicial);

        ExibirResultado(contagem);
    }

    static int LerNumeroInicial()
    {
        Console.Write("Digite um número inicial: ");

        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero)
               || numero < 0)
        {
            Console.WriteLine("Número inválido. Digite um valor positivo.");
            Console.Write("Digite um número inicial: ");
        }

        return numero;
    }

    static string GerarContagemRegressiva(int numeroInicial)
    {
        string resultado = "";

        for (int i = numeroInicial; i >= 0; i--)
        {
            resultado += i;

            if (i > 0)
            {
                resultado += ", ";
            }
        }

        return resultado;
    }

    static void ExibirResultado(string contagem)
    {
        Console.WriteLine();

        Console.WriteLine("===== CONTAGEM REGRESSIVA =====");
        Console.WriteLine(contagem);
    }
}