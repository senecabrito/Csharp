using System;
using Teste8.Classes;

namespace Teste8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Hospede[] hosp = new Hospede[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Dados do {i + 1}º hóspede:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                hosp[i] = new Hospede(nome, email, quarto);
            }

            // Ordena os hóspedes pelo número do quarto
            Array.Sort(hosp, (x, y) => x.Quarto.CompareTo(y.Quarto));

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < n; i++)
            {
                if (hosp[i] != null)
                {
                    Console.WriteLine($"{hosp[i].Quarto}: {hosp[i].Nome}, {hosp[i].Email}");
                }
            }


        }
    }
}