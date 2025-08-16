using System;
using ComparandoProdutos.Entities;
using ComparandoProdutos.Services;

namespace ComparandoProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Quantos produtos você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nProduto #{i + 1}:");
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                decimal price = decimal.Parse(vect[1]);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();
            Product max = calculationService.Max(list);

            Console.Write("\nProduto mais caro: ");
            Console.WriteLine(max);
        }
    }
}