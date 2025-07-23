namespace Atividade04.Entities;

internal class PessoaJuridica : Pessoa
{
    public int QuantidadeFuncionarios { get; private protected set; }

    public PessoaJuridica()
    {
    }

    public PessoaJuridica(string nome, decimal rendaAnual, int quantidadeFuncionarios)
    {
        Nome = nome;
        RendaAnual = rendaAnual;
        QuantidadeFuncionarios = quantidadeFuncionarios;
    }

    public override decimal CalculoImposto()
    {
        decimal imposto = 0;

        if (QuantidadeFuncionarios > 10)
        {
            imposto = RendaAnual * 0.14m;
        }
        else
        {
            imposto = RendaAnual * 0.16m;
        }

        return imposto < 0 ? 0 : imposto;
    }
}