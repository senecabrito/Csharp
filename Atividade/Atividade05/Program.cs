using System;
using Atividade05.Entities;
using Atividade05.Entities.Exceptions;

namespace Atividade05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o ID desta conta: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome do titular desta conta: ");
                string titular = Console.ReadLine();

                Console.Write("Deposite o valor inicial que esta conta terá: ");
                decimal depositoInicial = decimal.Parse(Console.ReadLine());

                Console.Write("Digite o limite de saque desta conta: ");
                decimal limiteSaque = decimal.Parse(Console.ReadLine());

                Conta c1 = new Conta(id, titular, depositoInicial, limiteSaque);

                Console.Write("Deseja depositar quanto? ");
                decimal depositoFinal = decimal.Parse(Console.ReadLine());
                c1.Depositar(depositoFinal);

                Console.Write("Deseja sacar quanto? ");
                decimal saque = decimal.Parse(Console.ReadLine());
                c1.RealizarSaque(saque);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de formatação: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Exceção de domínio: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}