namespace Teste2.Classes;

public class Produto // Encapsulamento de Dados com Validação de Dados, Construtores e Getter e Setters
{
    private string _nome;
    private decimal _preco;
    private int _quantidade;

    public Produto(string nome, decimal preco)
    {
        _nome = nome;
        _preco = preco;
        _quantidade = 0;
    }

    public Produto(string nome, decimal preco, int quantidade) : this(nome, preco)
    {
        _quantidade = quantidade;
    }

    public string GetNome()
    {
        return _nome;
    }

    public void SetNome(string nome)
    {
        if (nome != null && nome.Length > 1)
        {
            _nome = nome;
        }
    }

    public decimal GetPreco()
    {
        return _preco;
    }

    public int GetQuantidade()
    {
        return _quantidade;
    }

    public void AumentarQuantidade(int quantidade)
    {
        if (quantidade > 0)
        {
            _quantidade += quantidade;
        }
    }

    public void DiminuirQuantidade(int quantidade)
    {
        if (quantidade > 0 && _quantidade >= quantidade)
        {
            _quantidade -= quantidade;
        }
    }

    public override string ToString()
    {
        return $"Produto: {_nome}, Preço: {_preco:C}, Quantidade: {_quantidade}";
    }

}