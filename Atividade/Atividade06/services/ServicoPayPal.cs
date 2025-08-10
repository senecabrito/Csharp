namespace Atividade06.Services;

internal class ServicoPayPal : IServicoDePagamentoOnline
{
    private const decimal PorcentagemDaParcela = 0.02m;
    private const decimal JurosMensal = 0.01m;
    public decimal TaxaDePagamento(decimal valor)
    {
        return valor * PorcentagemDaParcela;
    }

    public decimal Juros(decimal valor, int meses)
    {
        return valor * JurosMensal * meses;
    }
}