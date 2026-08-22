using System;

namespace CSharpTP205;

class Program
{
    static void Main()
    {
        double celsius = LerTemperatura();

        double fahrenheit = ConverterParaFahrenheit(celsius);
        double kelvin = ConverterParaKelvin(celsius);

        ExibirResultado(celsius, fahrenheit, kelvin);
    }
    
    static double LerTemperatura()
    {
        Console.Write("Digite a temperatura em Celsius: ");

        double temperatura;

        while (!double.TryParse(Console.ReadLine(), out temperatura))
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
            Console.Write("Digite a temperatura em Celsius: ");
        }

        return temperatura;
    }

    static double ConverterParaFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    static double ConverterParaKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    static void ExibirResultado(
        double celsius,
        double fahrenheit,
        double kelvin)
    {
        Console.WriteLine();

        Console.WriteLine("===== CONVERSÃO =====");
        Console.WriteLine($"Celsius: {celsius:F2} °C");
        Console.WriteLine($"Fahrenheit: {fahrenheit:F2} °F");
        Console.WriteLine($"Kelvin: {kelvin:F2} K");
    }
}