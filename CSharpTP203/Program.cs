using System;

namespace CSharpTP203;

class Program
{
    static void Main()
    {
        DateTime primeiraData = LerData("Digite a primeira data (dd/MM/yyyy): ");
        DateTime segundaData = LerData("Digite a segunda data (dd/MM/yyyy): ");

        ExibirDiferenca(primeiraData, segundaData);
    }

    static DateTime LerData(string mensagem)
    {
        Console.Write(mensagem);

        DateTime data;

        while (!DateTime.TryParse(Console.ReadLine(), out data))
        {
            Console.WriteLine("Data inválida. Tente novamente.");
            Console.Write(mensagem);
        }

        return data;
    }

    static void ExibirDiferenca(DateTime primeiraData, DateTime segundaData)
    {
        if (primeiraData > segundaData)
        {
            DateTime auxiliar = primeiraData;
            primeiraData = segundaData;
            segundaData = auxiliar;
        }

        TimeSpan diferencaDias = segundaData - primeiraData;

        int anos = CalcularAnos(primeiraData, segundaData);
        int meses = CalcularMeses(primeiraData, segundaData);

        Console.WriteLine();
        Console.WriteLine("Diferença entre as datas:");
        Console.WriteLine($"Anos: {anos}");
        Console.WriteLine($"Meses: {meses}");
        Console.WriteLine($"Dias: {diferencaDias.Days}");
    }

    static int CalcularAnos(DateTime primeiraData, DateTime segundaData)
    {
        int anos = segundaData.Year - primeiraData.Year;

        if (segundaData.Month < primeiraData.Month ||
            (segundaData.Month == primeiraData.Month &&
             segundaData.Day < primeiraData.Day))
        {
            anos--;
        }

        return anos;
    }

    static int CalcularMeses(DateTime primeiraData, DateTime segundaData)
    {
        int meses = ((segundaData.Year - primeiraData.Year) * 12)
                    + segundaData.Month
                    - primeiraData.Month;

        if (segundaData.Day < primeiraData.Day)
        {
            meses--;
        }

        return meses;
    }
}