using System;
using System.IO;

namespace LerArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string caminho = @"/home/seneca/Csharp/ManipulandoArquivos/ArquivosParaTestes/file01.txt";
                string[] linhas = File.ReadAllLines(caminho); // lê e guarda todas as linhas do arquivo

                foreach (string l in linhas)
                {
                    Console.WriteLine(l);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu: " + e.Message);
            }
        }
    }
}