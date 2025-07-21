using System;
using Teste6.Classes;

namespace Teste6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            Produto[] vet = new Produto[n];
            decimal soma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                decimal preco = decimal.Parse(Console.ReadLine());
                vet[i] = new Produto(nome, preco);
                soma += vet[i].Preco;
            }

            decimal media = soma / n;

            Console.WriteLine();
            Console.WriteLine("Produtos cadastrados:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Produto {i + 1}:\nNome: {vet[i].Nome}\nPreço: {vet[i].Preco:C}\n");
            }
            
            Console.WriteLine($"Média dos preços dos produtos: {media:C}");


        }
    }
}