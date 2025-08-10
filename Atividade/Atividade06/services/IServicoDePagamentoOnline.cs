namespace Atividade06.Services;

internal interface IServicoDePagamentoOnline
{
    public decimal TaxaDePagamento(decimal valor);
    public decimal Juros(decimal valor, int meses);

}