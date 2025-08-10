using System;
using System.IO;

namespace CopiarTextoUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoOrigem = @"/home/seneca/Csharp/ManipulandoArquivos/ArquivosParaTestes/file01.txt";
            string caminhoDestino = @"/home/seneca/Csharp/ManipulandoArquivos/ArquivosParaTestes/file03.txt";

            try
            {
                string[] lines = File.ReadAllLines(caminhoOrigem); // armazena um vetor de strings com o conteúdo do arquivo

                using (StreamWriter sw = File.AppendText(caminhoDestino)) // Permite anexar textos e realizar o fechamento do SW ao final do programa
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper()); // escrever cada linha convertendo pra maiúsculas no final do arquivo
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