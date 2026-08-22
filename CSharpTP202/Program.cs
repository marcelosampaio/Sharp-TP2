using System;

namespace CSharpTP202;

class Program
{
    static void Main()
    {
        DateTime nascimento = LerDataNascimento();

        int dias = CalcularDiasProximoAniversario(nascimento);

        ExibirResultado(dias);
    }

    static DateTime LerDataNascimento()
    {
        Console.Write("Digite sua data de nascimento (dd/MM/yyyy): ");

        DateTime nascimento;

        while (!DateTime.TryParse(Console.ReadLine(), out nascimento) 
               || nascimento > DateTime.Today)
        {
            Console.WriteLine("Data inválida. Digite uma data de nascimento válida.");
            Console.Write("Digite sua data de nascimento (dd/MM/yyyy): ");
        }

        return nascimento;
    }

    static int CalcularDiasProximoAniversario(DateTime nascimento)
    {
        DateTime hoje = DateTime.Today;

        DateTime proximoAniversario = new DateTime(
            hoje.Year,
            nascimento.Month,
            nascimento.Day
        );

        if (proximoAniversario <= hoje)
        {
            proximoAniversario = proximoAniversario.AddYears(1);
        }

        return (proximoAniversario - hoje).Days;
    }

    static void ExibirResultado(int dias)
    {
        Console.WriteLine();
        Console.WriteLine($"Faltam {dias} dias para o próximo aniversário.");
    }
}