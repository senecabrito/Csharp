using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace Teste10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            nomes.Add("João");
            nomes.Add("Sêneca");
            nomes.Add("Leonardo");
            nomes.Add("Lívia");
            nomes.Insert(1, "Sofia");

            foreach (string n in nomes)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine($"Total de pessoas: {nomes.Count}");
            Console.WriteLine();

            string s1 = nomes.Find(x => x[0] == 'S'); // expressão lambda
            Console.WriteLine($"Primeiro nome que começa com 'S': {s1}");

            string s2 = nomes.FindLast(x => x[0] == 'S');
            Console.WriteLine($"Último nome que começa com 'S': {s2}");
            Console.WriteLine();

            int pos1 = 1 + nomes.FindIndex(x => x[0] == 'S'); // expressão lambda
            Console.WriteLine($"Posição do primeiro nome que começa com 'S': {pos1}");

            int pos2 = 1 + nomes.FindLastIndex(x => x[0] == 'S');
            Console.WriteLine($"Posição do último nome que começa com 'S': {pos2}");
            Console.WriteLine();

            List<string> nomes2 = nomes.FindAll(x => x.Length == 5);
            Console.WriteLine("Todos os nomes com 5 letras:");
            foreach (string n in nomes2)
            {
                Console.WriteLine(n);
            }

            // nomes.Remove("Sofia"); // Remove a primeira ocorrência de "Sofia"
            // nomes.RemoveAt(1); // Remove o elemento na posição 1
            // nomes.RemoveRange(1, 2); // Remove os elementos da posição 1 até a 2


        }
    }
}