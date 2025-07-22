using System;
using Teste18.Entities; // necessário para acessar a classe

class Program
{
    static void Main()
    {
        Console.Write("Digite um CPF: ");
        string cpf = Console.ReadLine();

        if (ValidadorCpf.EhValido(cpf))
            Console.WriteLine("CPF válido ✅");
        else
            Console.WriteLine("CPF inválido ❌");
    }
}
