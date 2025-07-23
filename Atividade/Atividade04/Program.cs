using Atividade04.Entities;
using System.Collections.Generic;

namespace Atividade04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade = InformarQuantidade();
            List<Pessoa> pessoas = CadastrarContribuintes(quantidade);
            ExibirImpostos(pessoas);
        }

        static int InformarQuantidade()
        {
            Console.Write("Informe a quantidade de contribuintes: ");
            return int.Parse(Console.ReadLine()!);
        }

        static List<Pessoa> CadastrarContribuintes(int quantidade)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"\nDados do contribuinte #{i + 1}:");
                Console.Write("Pessoa Física ou Jurídica (f/j)? ");
                char tipo = char.Parse(Console.ReadLine()!.ToLower());

                Console.Write("Nome: ");
                string nome = Console.ReadLine()!;

                Console.Write("Renda Anual: ");
                decimal rendaAnual = decimal.Parse(Console.ReadLine()!);

                if (tipo == 'f')
                {
                    Console.Write("Gasto com saúde: ");
                    decimal gastoSaude = decimal.Parse(Console.ReadLine()!);
                    pessoas.Add(new PessoaFisica(nome, rendaAnual, gastoSaude));
                }
                else
                {
                    Console.Write("Quantidade de funcionários: ");
                    int quantidadeFuncionarios = int.Parse(Console.ReadLine()!);
                    pessoas.Add(new PessoaJuridica(nome, rendaAnual, quantidadeFuncionarios));
                }
            }

            return pessoas;
        }

        static void ExibirImpostos(List<Pessoa> pessoas)
        {
            Console.WriteLine("\nImpostos a pagar:");
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.Nome}: R$ {pessoa.CalculoImposto():F2}");
            }

        }
    }
}