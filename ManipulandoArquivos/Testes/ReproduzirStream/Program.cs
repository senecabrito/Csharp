using System;
using System.IO;

namespace ReproduzirStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"/home/seneca/Csharp/ManipulandoArquivos/ArquivosParaTestes/file01.txt";

            try
            {
                using (StreamReader sr = File.OpenText(caminho))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu: " + e.Message);
            }
        }
    }
}