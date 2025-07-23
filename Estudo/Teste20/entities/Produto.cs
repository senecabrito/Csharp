namespace Teste20.Entities;

internal class Produto
{
    public string Nome { get; private protected set; }
    public decimal Preco { get; private protected set; }

    public Produto()
    {
    }

    public Produto(string nome, decimal preco) : this()
    {
        Nome = nome;
        Preco = preco;
    }

    public virtual string EtiquetaPreco()
    {
        return $"{Nome} - {Preco:C}";
    } 

}