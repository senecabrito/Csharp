using System;
using Teste7.Classes;

namespace Avaliacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal depositoInicial = 0;
            ContaBancaria c1;

            Console.Write("Entre com o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine().ToLower());

            if (resposta == 's')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                depositoInicial = decimal.Parse(Console.ReadLine());
                c1 = new ContaBancaria(numConta, nomeTitular, depositoInicial);
            }
            else
            {

                c1 = new ContaBancaria(numConta, nomeTitular);
            }
            
            Console.WriteLine();
            Console.WriteLine(c1.ToString());
            Console.ReadLine();

        }
    }
}