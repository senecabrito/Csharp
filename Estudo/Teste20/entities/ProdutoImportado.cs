namespace Teste20.Entities;

internal class ProdutoImportado : Produto
{
    public decimal TaxaImportacao { get; private protected set; }

    public ProdutoImportado(string nome, decimal preco, decimal taxaImportacao) : base(nome, preco)
    {
        Preco += taxaImportacao; // Inclui a taxa de importação no preço
        TaxaImportacao = taxaImportacao;
    }

    public override string EtiquetaPreco()
    {
        return $"{Nome} - {Preco:C} (Taxa de Importação: {TaxaImportacao:C})";
    }

    public decimal PrecoTotal()
    {
        return Preco + TaxaImportacao;
    }
    
}