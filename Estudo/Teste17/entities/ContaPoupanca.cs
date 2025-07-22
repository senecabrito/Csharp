namespace Teste17.Entities
{
    public class ContaPoupanca : Conta
    {
        public decimal TaxaDeJuros { get; protected set; }

        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int id, string titular, decimal saldo, decimal taxaDeJuros)
            : base(id, titular, saldo) // Chama o construtor da classe base Conta
        {
            TaxaDeJuros = taxaDeJuros;
        }

        public void AplicarJuros()
        {
            if (TaxaDeJuros <= 0)
            {
                throw new ArgumentException("Taxa de juros deve ser positiva.");
            }
            else
            {
                Saldo += Saldo * TaxaDeJuros / 100; // Aplica a taxa de juros ao saldo
            }
        }

    }
}