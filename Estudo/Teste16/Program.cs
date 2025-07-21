using System;
using Teste16.Entities;
using Teste16.Entities.Enums;

namespace Teste16
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido p1 = new Pedido
            {
                Id = 1,
                Momento = DateTime.Now,
                Status = StatusPedido.Pendente
            };

            Console.WriteLine($"Pedido ID: {p1.Id}");
            Console.WriteLine($"Momento: {p1.Momento}");
            Console.WriteLine($"Status: {p1.Status}");

        }
    }
}