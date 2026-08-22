using System;

namespace CSharpTP208;

class Program
{
    static void Main()
    {
        double nota = LerNota();

        string classificacao = ClassificarNota(nota);

        ExibirResultado(nota, classificacao);
    }

    static double LerNota()
    {
        Console.Write("Digite a nota (0 a 10): ");

        double nota;

        while (!double.TryParse(Console.ReadLine(), out nota)
               || nota < 0
               || nota > 10)
        {
            Console.WriteLine("Nota inválida. Digite um valor entre 0 e 10.");
            Console.Write("Digite a nota (0 a 10): ");
        }

        return nota;
    }

    static string ClassificarNota(double nota)
    {
        if (nota < 6)
        {
            return "Insuficiente";
        }
        else if (nota < 7)
        {
            return "Regular";
        }
        else if (nota < 9)
        {
            return "Bom";
        }
        else
        {
            return "Excelente";
        }
    }

    static void ExibirResultado(double nota, string classificacao)
    {
        Console.WriteLine();

        Console.WriteLine("===== RESULTADO =====");
        Console.WriteLine($"Nota: {nota:F2}");
        Console.WriteLine($"Classificação: {classificacao}");
    }
}