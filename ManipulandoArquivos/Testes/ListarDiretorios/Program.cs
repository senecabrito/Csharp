using System;
using System.IO;
using System.Collections.Generic;

namespace ListarDiretorios
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "/home/seneca/Csharp/ManipulandoArquivos/ArquivosParaTestes";
                IEnumerable<string> diretorios = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // armazenando todas as subpastas através do PATH

                Console.WriteLine("Subpastas:");
                foreach (string s in diretorios)
                {
                    Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // armazenando todos os subarquivos através do PATH
                Console.WriteLine("Subarquivos:");

                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro inesperado ocorreu: " + e.Message);
            }
        }
    }
}