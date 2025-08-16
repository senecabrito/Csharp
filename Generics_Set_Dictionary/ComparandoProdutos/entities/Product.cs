namespace ComparandoProdutos.Entities;

public class Product : IComparable
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name}\nPreço: {Price:C}";
    }

    public int CompareTo(object obj)
    {
        if (obj == null) return 1; // null é considerado menor que qualquer instância
        if (!(obj is Product))
        {
            throw new ArgumentException("Erro: Comparação inválida. O objeto não é um Produto.");
        }

        Product other = obj as Product; // faz o cast do objeto para Product
        return Price.CompareTo(other.Price); // compara os preços dos produtos

    }

}