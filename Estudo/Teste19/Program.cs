using System.Collections.Generic;
using Teste19.Entities;

namespace Teste19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeFuncionarios = InformarQuantidadeFuncionarios();
            List<Funcionario> funcionarios = CadastrarFuncionarios(quantidadeFuncionarios);
            ExibirSalarios(funcionarios);
        }

        static int InformarQuantidadeFuncionarios()
        {
            Console.Write("Informe a quantidade de funcionários: ");
            int quantidade;
            while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0) ; // loop pra garantir que a entrada é válida
            return quantidade;
        }

        static List<Funcionario> CadastrarFuncionarios(int quantidade)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"\nFuncionário {i + 1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Horas Trabalhadas: ");
                int horasTrabalhadas;
                while (!int.TryParse(Console.ReadLine(), out horasTrabalhadas) || horasTrabalhadas < 0) ;

                Console.Write("Valor por Hora: ");
                decimal valorHora;
                while (!decimal.TryParse(Console.ReadLine(), out valorHora) || valorHora < 0) ;

                Console.Write("É terceirizado? (s/n): ");
                string resposta = Console.ReadLine().ToLower();

                if (resposta == "s")
                {
                    Console.Write("Adicional: ");
                    decimal adicional;
                    while (!decimal.TryParse(Console.ReadLine(), out adicional) || adicional < 0) ;

                    funcionarios.Add(new FuncionarioTerceirizado(nome, horasTrabalhadas, valorHora, adicional));
                }
                else
                {
                    funcionarios.Add(new Funcionario(nome, horasTrabalhadas, valorHora));
                }
            }
            return funcionarios;
        }

        static void ExibirSalarios(List<Funcionario> funcionarios)
        {
            Console.WriteLine("\nSalários dos Funcionários:");
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }

        }
    }
}