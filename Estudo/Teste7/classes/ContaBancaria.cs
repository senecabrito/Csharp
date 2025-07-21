namespace Teste7.Classes
{
    public class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        public ContaBancaria(int numero, string titular, decimal depositoInicial) : this(numero, titular)
        {
            Saldo = depositoInicial;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor do depósito deve ser positivo."); // Usado pq o argumento é inválido
            }
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor do saque deve ser positivo."); // Usado pq o argumento é inválido
            }
            if (valor > Saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente para saque."); // Usado pq a operação não pode ser realizada no estado atual do objeto
            }
            Saldo -= valor;
        }

        public override string ToString()
        {
            return $"Conta: {Numero}\nTitular: {Titular}\nSaldo: {Saldo:C}";
        }
        
    }
}