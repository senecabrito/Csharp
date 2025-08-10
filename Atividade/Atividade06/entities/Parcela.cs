namespace Atividade06.Entities;

internal class Parcela
{
    public DateTime Vencimento { get; private set; }
    public decimal Valor { get; private set; }

    public Parcela()
    {
    }

    public Parcela(DateTime vencimento, decimal valor)
    {
        Vencimento = vencimento;
        Valor = valor;
    }

    public override string ToString()
    {
        return $"Vencimento: {Vencimento:dd/MM/yyyy}\nValor: {Valor:C}";
    }

}