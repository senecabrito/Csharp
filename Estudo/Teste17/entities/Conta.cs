using System.Text;

namespace Teste17.Entities
{
    public class Conta
    {
        public int Id { get; protected set; }
        public string Titular { get; protected set; }
        public decimal Saldo { get; protected set; }

        public Conta()
        {
        }

        public Conta(int id, string titular, decimal saldo) : this()
        {
            Id = id;
            Titular = titular;
            Saldo = saldo;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor de depósito deve ser positivo.");
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor de saque deve ser positivo.");
            }
            else if (valor > Saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente para saque.");
            }
            else
            {
                Saldo -= valor;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // StringBuilder para construir a string de saída
            sb.AppendLine("Dados da Conta:");
            sb.AppendLine($"ID: {Id}");
            sb.AppendLine($"Titular: {Titular}");
            sb.AppendLine($"Saldo: {Saldo:C}");
            return sb.ToString();
        }

    }
}