namespace Teste17.Entities
{
    public class ContaEmpresarial : Conta
    {
        public decimal LimiteEmprestimo { get; protected set; }

        public ContaEmpresarial()
        {
        }

        public ContaEmpresarial(int id, string titular, decimal saldo, decimal limiteEmprestimo)
            : base(id, titular, saldo) // Chama o construtor da classe base Conta
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void RealizarEmprestimo(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor do empréstimo deve ser positivo.");
            if (valor > LimiteEmprestimo)
                throw new InvalidOperationException("Valor do empréstimo excede o limite permitido.");
            Saldo += valor;
        }

        public override void Sacar(decimal valor) // Sobrescreve o método Sacar para aplicar taxa de saque
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor de saque deve ser positivo.");
            }
            else if (valor > Saldo + LimiteEmprestimo)
            {
                throw new InvalidOperationException("Saldo insuficiente para saque.");
            }
            else
            {
                base.Sacar(valor); // Chama o método Sacar da classe base Conta
                Saldo -= 2; // Taxa de saque total de R$7,00 para Conta Empresarial
            }
        }
        
    }
}