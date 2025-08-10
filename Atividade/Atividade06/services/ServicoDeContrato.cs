using Atividade06.Entities;
namespace Atividade06.Services;

internal class ServicoDeContrato
{
    private IServicoDePagamentoOnline _servicoDePagamentoOnline;

    public ServicoDeContrato(IServicoDePagamentoOnline servicoDePagamentoOnline)
    {
        _servicoDePagamentoOnline = servicoDePagamentoOnline;
    }

    public void ProcessarContrato(Contrato contrato, int meses)
    {
        decimal ParcelaBasica = contrato.ValorTotal / meses;
        for (int i = 0; i < meses; i++)
        {
            DateTime data = contrato.Data.AddMonths(i+1);
            decimal ParcelaAtualizada = ParcelaBasica + _servicoDePagamentoOnline.Juros(ParcelaBasica, i);
            decimal ParcelaTotal = ParcelaAtualizada + _servicoDePagamentoOnline.TaxaDePagamento(ParcelaAtualizada);
            contrato.AddParcela(new Parcela(data, ParcelaTotal));
        }
    }
}