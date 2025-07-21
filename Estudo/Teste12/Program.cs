using System;
using System.Collections.Generic;

namespace Teste12
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativos = 0;
            List<int> diagonalPrincipal = new List<int>();

            Console.Write("Digite a quantidade de linhas: ");
            int linhas = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de colunas: ");
            int colunas = int.Parse(Console.ReadLine());
            int[,] mat = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {

                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Digite o valor da linha {i + 1}, coluna {j + 1}: ");
                    int num = int.Parse(Console.ReadLine());

                    if (num < 0)
                    {
                        negativos++; // Incrementa o contador de negativos
                    }

                    if (i == j)
                    {
                        diagonalPrincipal.Add(num); // Adiciona o número à diagonal principal
                    }

                    mat[i, j] = num;
                }
            }

            Console.WriteLine("Matriz:");
            foreach (int num in mat)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine($"\nQuantidade de números negativos: {negativos}");

            Console.WriteLine("Números na diagonal principal:");
            foreach (int num in diagonalPrincipal)
            {
                Console.Write(num + " ");
            }

            // Console.WriteLine(mat.Length); // Exibe o tamanho total da matriz
            // Console.WriteLine(mat.Rank); // Exibe a quantidade de dimensões da matriz
            // Console.WriteLine(mat.GetLength(0)); // Exibe a quantidade de linhas da matriz
            // Console.WriteLine(mat.GetLength(1)); // Exibe a quantidade de colunas da matriz

        }
    }
}
