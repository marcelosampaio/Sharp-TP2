using System;

namespace CSharpTP204;

class Program
{
    static void Main()
    {
        string nome = LerNome();
        int idade = LerIdade();
        string telefone = LerTelefone();
        string email = LerEmail();

        ExibirCadastro(nome, idade, telefone, email);
    }

    static string LerNome()
    {
        Console.Write("Digite seu nome: ");

        string nome = Console.ReadLine() ?? "";

        while (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome obrigatório. Tente novamente.");
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine() ?? "";
        }

        return nome;
    }

    static int LerIdade()
    {
        Console.Write("Digite sua idade: ");

        int idade;

        while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0)
        {
            Console.WriteLine("Idade inválida. Tente novamente.");
            Console.Write("Digite sua idade: ");
        }

        return idade;
    }

    static string LerTelefone()
    {
        Console.Write("Digite seu telefone: ");

        string telefone = Console.ReadLine() ?? "";

        while (string.IsNullOrWhiteSpace(telefone))
        {
            Console.WriteLine("Telefone obrigatório. Tente novamente.");
            Console.Write("Digite seu telefone: ");
            telefone = Console.ReadLine() ?? "";
        }

        return telefone;
    }

    static string LerEmail()
    {
        Console.Write("Digite seu e-mail: ");

        string email = Console.ReadLine() ?? "";

        while (!EmailValido(email))
        {
            Console.WriteLine("E-mail inválido. Tente novamente.");
            Console.Write("Digite seu e-mail: ");
            email = Console.ReadLine() ?? "";
        }

        return email;
    }

    static bool EmailValido(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }

    static void ExibirCadastro(
        string nome,
        int idade,
        string telefone,
        string email)
    {
        Console.WriteLine();
        Console.WriteLine("===== CADASTRO =====");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Telefone: {telefone}");
        Console.WriteLine($"E-mail: {email}");
    }
}