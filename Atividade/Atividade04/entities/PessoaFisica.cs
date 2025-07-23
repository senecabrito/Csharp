namespace Atividade04.Entities;

internal class PessoaFisica : Pessoa
{
    public decimal GastoSaude { get; private protected set; }

    public PessoaFisica()
    {
    }

    public PessoaFisica(string nome, decimal rendaAnual, decimal gastoSaude) : base(nome, rendaAnual)
    {
        GastoSaude = gastoSaude;
    }

    public override decimal CalculoImposto()
    {
        decimal imposto = 0;

        if (RendaAnual < 20000)
        {
            imposto = RendaAnual * 0.15m;
        }
        else
        {
            imposto = RendaAnual * 0.25m;
        }

        if (GastoSaude > 0)
        {
            imposto -= GastoSaude * 0.50m;
        }

        return (imposto < 0) ? 0 : imposto;
    }

}