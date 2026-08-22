using System;

namespace CSharpTP212;

class Program
{
    static void Main()
    {
        int numeroSecreto = GerarNumeroSecreto();

        Jogar(numeroSecreto);
    }

    static int GerarNumeroSecreto()
    {
        Random random = new Random();

        return random.Next(1, 101);
    }

    static void Jogar(int numeroSecreto)
    {
        bool acertou = false;

        Console.WriteLine("===== JOGO DE ADIVINHAÇÃO =====");
        Console.WriteLine("Tente descobrir o número entre 1 e 100.");

        while (!acertou)
        {
            int palpite = LerPalpite();

            if (palpite < numeroSecreto)
            {
                Console.WriteLine("O número secreto é maior.");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("O número secreto é menor.");
            }
            else
            {
                Console.WriteLine("Parabéns! Você acertou.");
                acertou = true;
            }
        }
    }

    static int LerPalpite()
    {
        Console.Write("Digite seu palpite: ");

        int palpite;

        while (!int.TryParse(Console.ReadLine(), out palpite)
               || palpite < 1
               || palpite > 100)
        {
            Console.WriteLine("Digite um número entre 1 e 100.");
            Console.Write("Digite seu palpite: ");
        }

        return palpite;
    }
}