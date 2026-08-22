using System;

namespace CSharpTP201;

class Program
{
    static void Main()
    {
        DateTime nascimento = LerDataNascimento();

        int anos = CalcularAnos(nascimento);
        int meses = CalcularMeses(nascimento, anos);
        int dias = CalcularDias(nascimento, anos, meses);

        ExibirResultado(anos, meses, dias);
    }

    static DateTime LerDataNascimento()
    {
        Console.Write("Digite sua data de nascimento (dd/MM/yyyy): ");

        DateTime nascimento;

        while (!DateTime.TryParse(Console.ReadLine(), out nascimento))
        {
            Console.WriteLine("Data inválida. Tente novamente.");
            Console.Write("Digite sua data de nascimento (dd/MM/yyyy): ");
        }

        return nascimento;
    }

    static int CalcularAnos(DateTime nascimento)
    {
        DateTime hoje = DateTime.Today;

        int anos = hoje.Year - nascimento.Year;

        DateTime aniversarioEsteAno = new DateTime(
            hoje.Year,
            nascimento.Month,
            nascimento.Day
        );

        if (aniversarioEsteAno > hoje)
        {
            anos--;
        }

        return anos;
    }

    static int CalcularMeses(DateTime nascimento, int anos)
    {
        DateTime hoje = DateTime.Today;

        DateTime ultimoAniversario = nascimento.AddYears(anos);

        int meses = hoje.Month - ultimoAniversario.Month;

        if (hoje.Day < ultimoAniversario.Day)
        {
            meses--;
        }

        if (meses < 0)
        {
            meses += 12;
        }

        return meses;
    }

    static int CalcularDias(DateTime nascimento, int anos, int meses)
    {
        DateTime hoje = DateTime.Today;

        DateTime ultimoAniversario = nascimento.AddYears(anos);
        DateTime ultimoMesCompleto = ultimoAniversario.AddMonths(meses);

        return (hoje - ultimoMesCompleto).Days;
    }

    static void ExibirResultado(int anos, int meses, int dias)
    {
        Console.WriteLine();
        Console.WriteLine($"Idade: {anos} anos, {meses} meses e {dias} dias.");
    }
}