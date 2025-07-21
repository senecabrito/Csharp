using System;
using Teste3.Classes;

namespace Teste3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("Camiseta", 29.99m);
            p1.Nome = "Camiseta Azul";
            p1.AdicionarQuantidade(25);
            p1.RemoverQuantidade(5);
            Console.WriteLine(p1.ToString());
            Console.ReadLine();
        }
    }
}
