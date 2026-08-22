using System;

namespace CSharpTP206;

class Program
{
    static void Main()
    {
        double peso = LerPeso();
        double altura = LerAltura();

        double imc = CalcularIMC(peso, altura);
        string classificacao = ClassificarIMC(imc);

        ExibirResultado(imc, classificacao);
    }

    static double LerPeso()
    {
        Console.Write("Digite seu peso em kg: ");

        double peso;

        while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0)
        {
            Console.WriteLine("Peso inválido. Tente novamente.");
            Console.Write("Digite seu peso em kg: ");
        }

        return peso;
    }

    static double LerAltura()
    {
        Console.Write("Digite sua altura em metros: ");

        double altura;

        while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
        {
            Console.WriteLine("Altura inválida. Tente novamente.");
            Console.Write("Digite sua altura em metros: ");
        }

        return altura;
    }

    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    static string ClassificarIMC(double imc)
    {
        if (imc < 18.5)
        {
            return "Abaixo do peso";
        }
        else if (imc < 25)
        {
            return "Peso normal";
        }
        else if (imc < 30)
        {
            return "Sobrepeso";
        }
        else
        {
            return "Obesidade";
        }
    }

    static void ExibirResultado(double imc, string classificacao)
    {
        Console.WriteLine();

        Console.WriteLine("===== RESULTADO IMC =====");
        Console.WriteLine($"IMC: {imc:F2}");
        Console.WriteLine($"Classificação: {classificacao}");
    }
}