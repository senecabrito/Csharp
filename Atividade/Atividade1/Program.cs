using System;
using Atividade1.Entities;
using Atividade1.Entities.Enums;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            Trabalhador trabalhador = CriarTrabalhador();
            MostrarRenda(trabalhador);
        }

        static Trabalhador CriarTrabalhador()
        {
            Console.Write("Entre com o departamento: ");
            string departamento = Console.ReadLine();

            Console.WriteLine("\nEntre com os dados do funcionário.");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nível (Junior, Pleno, Senior): ");
            NivelProfissional nivel = Enum.Parse<NivelProfissional>(Console.ReadLine());

            Console.Write("Salário: ");
            double baseSalario = double.Parse(Console.ReadLine());

            Departamento dep = new Departamento(departamento);
            Trabalhador t1 = new Trabalhador(nome, nivel, (decimal)baseSalario, dep);

            Console.Write("\nQuantos contratos esse funcionário possui? ");
            int contratos = int.Parse(Console.ReadLine());

            for (int i = 0; i < contratos; i++)
            {
                Console.WriteLine($"\nEntre com os dados do contrato #{i + 1}.");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor Por Hora: ");
                decimal valorHora = decimal.Parse(Console.ReadLine());

                Console.Write("Duração (Horas): ");
                int horas = int.Parse(Console.ReadLine());

                ContratoHoras contrato = new ContratoHoras(data, valorHora, horas);
                t1.AdicionarContrato(contrato);
            }

            return t1;
        }

        static void MostrarRenda(Trabalhador t1)
        {
            Console.Write("\nDigite o mês e o ano para calcular a renda (MM/YYYY): ");
            string mesAno = Console.ReadLine();

            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3, 4));

            Console.WriteLine($"\nNome: {t1.Nome}");
            Console.WriteLine($"Departamento: {t1.Departamento.Nome}");
            Console.WriteLine($"Renda em {mesAno}: {t1.Renda(mes, ano):C}");
        }
    }
}
