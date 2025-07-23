namespace Teste20.Entities;

internal class ProdutoUsado : Produto
{
    public DateTime DataFabricacao { get; private protected set; }

    public ProdutoUsado()
    {
    }

    public ProdutoUsado(string nome, decimal preco, DateTime dataFabricacao) : base(nome, preco)
    {
        DataFabricacao = dataFabricacao;
    }

    public override string ToString()
    {
        return $"{Nome} (Usado) - {Preco:C} - (Data de Fabricação: {DataFabricacao:dd/MM/yyyy})";
    }

}