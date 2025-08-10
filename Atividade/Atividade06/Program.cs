using Atividade06.Entities;
using Atividade06.Services;

namespace Atividade06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do contrato.");
            Console.Write("ID do contrato: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Data do contrato (DD/MM/YYYY): ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            Console.Write("Valor do contrato: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.Write("Número de parcelas: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato MeuContrato = new Contrato(id, data, valor);

            ServicoDeContrato servicoDeContrato = new ServicoDeContrato(new ServicoPayPal());
            servicoDeContrato.ProcessarContrato(MeuContrato, meses);

            Console.WriteLine("\nParcelas:");
            foreach (Parcela p in MeuContrato.Parcelas)
            {
                Console.WriteLine(p);
            }
            
        }
    }
}