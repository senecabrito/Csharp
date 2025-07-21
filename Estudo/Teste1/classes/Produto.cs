namespace Teste1.Classes
{
    public class Produto
    {
        public string Nome;
        public decimal Preco;
        public int Quantidade;

        public Produto() // Construtor padrão
        {
        }

        public Produto(string nome, decimal preco) : this() // Construtor com dois parâmetros
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, decimal preco, int quantidade) : this(nome, preco) // Construtor completo
        {
            Quantidade = quantidade;
        }
        

    }
}