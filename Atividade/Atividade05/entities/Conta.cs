using Atividade05.Entities.Exceptions;
namespace Atividade05.Entities;

internal class Conta
{
    public int ID { get; private protected set; }
    public string Titular { get; private protected set; }
    public decimal SaldoInicial { get; private protected set; }
    public decimal LimiteSaque { get; private protected set; }

    public Conta()
    {
    }

    public Conta(int iD, string titular, decimal saldoInicial, decimal limiteSaque) : this()
    {
        ID = iD;
        Titular = titular;
        SaldoInicial = saldoInicial;
        LimiteSaque = limiteSaque;
    }

    public void Depositar(decimal valor)
    {
        if (valor >= 0)
        {
            SaldoInicial += valor;
        }
        else
        {
            throw new DomainException("Não é possível depositar um valor negativo.");
        }
    }

    public void RealizarSaque(decimal valor)
    {
        if (SaldoInicial == 0)
        {
            throw new DomainException("A conta não tem saldo.");
        }
        else if (valor > SaldoInicial)
        {
            throw new DomainException("O valor solicitado é maior que o saldo da conta.");
        }
        else if (valor > LimiteSaque)
        {
            throw new DomainException("O valor solicitado é maior que o limite de saque da conta.");
        }
        else
        {
            SaldoInicial -= valor;
        }
    }

}