using System;

namespace Teste5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de pessoas:");
            int n = int.Parse(Console.ReadLine());
            decimal[] vetor = new decimal[n];
            decimal soma = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite a altura da pessoa {i + 1}:");
                vetor[i] = decimal.Parse(Console.ReadLine());
                soma += vetor[i];
            }

            decimal media = soma / n;
            Console.WriteLine($"A média de altura é: {media:F2}m"); // Formato com duas casas decimais

        }
    }
}