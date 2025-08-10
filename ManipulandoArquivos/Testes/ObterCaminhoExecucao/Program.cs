using System;
using System.IO;

namespace MostrarCaminhoAtual
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoAtual = Directory.GetCurrentDirectory(); // guarda o caminho exato onde o projeto está rodando
            Console.WriteLine($"Caminho atual: {caminhoAtual}");
        }
    }
}