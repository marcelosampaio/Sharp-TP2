using System;

namespace CSharpTP201;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua data de nascimento (dd/MM/yyyy): ");

        DateTime nascimento;

        if (DateTime.TryParse(Console.ReadLine(), out nascimento))
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

            DateTime ultimoMesCompleto = ultimoAniversario.AddMonths(meses);

            int dias = (hoje - ultimoMesCompleto).Days;

            Console.WriteLine();
            Console.WriteLine($"Idade: {anos} anos, {meses} meses e {dias} dias.");
        }
        else
        {
            Console.WriteLine("Data inválida.");
        }
    }
}