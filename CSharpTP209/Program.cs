using System;

namespace CSharpTP209;

class Program
{
    static void Main()
    {
        double salarioBruto = LerSalarioBruto();

        double aliquota = CalcularAliquota(salarioBruto);
        double desconto = CalcularDesconto(salarioBruto, aliquota);
        double salarioLiquido = CalcularSalarioLiquido(salarioBruto, desconto);

        ExibirResultado(
            salarioBruto,
            aliquota,
            desconto,
            salarioLiquido
        );
    }

    static double LerSalarioBruto()
    {
        Console.Write("Digite o salário bruto: ");

        double salario;

        while (!double.TryParse(Console.ReadLine(), out salario)
               || salario < 0)
        {
            Console.WriteLine("Salário inválido. Tente novamente.");
            Console.Write("Digite o salário bruto: ");
        }

        return salario;
    }

    static double CalcularAliquota(double salario)
    {
        if (salario <= 2000)
        {
            return 0.08;
        }
        else if (salario <= 5000)
        {
            return 0.18;
        }
        else
        {
            return 0.275;
        }
    }

    static double CalcularDesconto(double salario, double aliquota)
    {
        return salario * aliquota;
    }

    static double CalcularSalarioLiquido(
        double salarioBruto,
        double desconto)
    {
        return salarioBruto - desconto;
    }

    static void ExibirResultado(
        double salarioBruto,
        double aliquota,
        double desconto,
        double salarioLiquido)
    {
        Console.WriteLine();

        Console.WriteLine("===== SALÁRIO =====");
        Console.WriteLine($"Salário bruto: R$ {salarioBruto:F2}");
        Console.WriteLine($"Alíquota aplicada: {aliquota:P0}");
        Console.WriteLine($"Desconto: R$ {desconto:F2}");
        Console.WriteLine($"Salário líquido: R$ {salarioLiquido:F2}");
    }
}