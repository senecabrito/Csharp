using Teste20.Entities;
using System.Collections.Generic;

namespace Teste20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade = InformarQuantidadeProdutos();
            List<Produto> produtos = CadastrarProdutos(quantidade);
            ExibirEtiquetas(produtos);
        }

        static int InformarQuantidadeProdutos()
        {
            Console.Write("Quantos produtos você vai cadastrar? ");
            return int.Parse(Console.ReadLine());
        }

        static List<Produto> CadastrarProdutos(int quantidade)
        {
            List<Produto> produtos = new List<Produto>();

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"\nProduto #{i + 1}");

                Console.Write("Comum, Usado ou Importado (c/u/i)? ");
                char tipoProduto = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                decimal preco = decimal.Parse(Console.ReadLine());

                if (tipoProduto == 'c')
                {
                    produtos.Add(new Produto(nome, preco));
                }
                else if (tipoProduto == 'u')
                {
                    Console.Write("Data de Fabricação (DD/MM/YYYY): ");
                    DateTime dataFabricacao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    produtos.Add(new ProdutoUsado(nome, preco, dataFabricacao));
                }
                else if (tipoProduto == 'i')
                {
                    Console.Write("Taxa de Importação: ");
                    decimal taxaImportacao = decimal.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoImportado(nome, preco, taxaImportacao));
                }

            }

            return produtos;
        }

        static void ExibirEtiquetas(List<Produto> produtos)
        {
            Console.WriteLine("\nEtiquetas de Preço:");
            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto.EtiquetaPreco());
            }
        }
        
    }
}