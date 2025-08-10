using System;
using System.Diagnostics.Contracts;
using System.IO;

namespace CopiarArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string CaminhoOrigem = @"/home/seneca/Csharp/ManipulandoArquivos/ArquivosParaTestes/file01.txt";
            string CaminhoDestino = @"/home/seneca/Csharp/ManipulandoArquivos/ArquivosParaTestes/file02.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(CaminhoOrigem);
                fileInfo.CopyTo(CaminhoDestino); // copia o arquivo 01 para o 02
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu: " + e.Message);
            }
        }
    }
}