using System;
using Teste1.Classes;

class Program
{
    static void Main()
    {
        Produto p1 = new Produto("Arame", 7.80m, 5); // 'M' para decimal
        Console.WriteLine($"Produto: {p1.Nome}, Preço: {p1.Preco:C}, Quantidade: {p1.Quantidade}"); // :C para formatar o valor como moeda
    }
}