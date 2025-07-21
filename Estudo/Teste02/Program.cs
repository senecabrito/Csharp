using System;
using Teste2.Classes;

namespace Teste2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("Arame", 10.50m, 50);
            p1.AumentarQuantidade(51);
            Console.WriteLine($"Quantidade: {p1.GetQuantidade()}");
            Console.ReadLine();
        }
    }
}