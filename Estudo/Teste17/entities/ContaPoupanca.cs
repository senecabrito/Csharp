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

        public override void Sacar(decimal valor) // Sobrescreve o método Sacar para não aplicar taxa de saque
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
                Saldo -= valor; // Não há taxa de saque para Conta Poupança
            }
        }

    }
}