namespace Atividade04.Entities;

abstract class Pessoa
{
    public string Nome { get; private protected set; }
    public decimal RendaAnual { get; private protected set; }

    public Pessoa()
    {
    }

    public Pessoa(string nome, decimal rendaAnual) : this()
    {
        Nome = nome;
        RendaAnual = rendaAnual;
    }

    public abstract decimal CalculoImposto();

}