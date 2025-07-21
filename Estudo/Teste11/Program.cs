using System;
using System.Collections.Generic;
using Teste11.Entities;

namespace Teste11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();
            Console.Write("Quantos funcionários deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o nome do funcionário {i + 1}: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Digite o salário: ");
                decimal salario = decimal.Parse(Console.ReadLine());

                list.Add(new Funcionario(nome, id, salario));
                Console.WriteLine();
            }

            Console.Write("Entre com o ID do funcionário que receberá um aumento: ");
            int idAumento = int.Parse(Console.ReadLine());

            Funcionario funcionario = list.Find(f => f.Id == idAumento);

            if (funcionario != null)
            {
                Console.Write("Digite a porcentagem do aumento: ");
                decimal porcentagem = decimal.Parse(Console.ReadLine());
                funcionario.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("ID não encontrado. Nenhum aumento aplicado.");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizada:");
            Console.WriteLine("----------------------------------------------");
            foreach (Funcionario f in list)
            {
                Console.WriteLine(f.ToString());
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------");
        }
    }
}