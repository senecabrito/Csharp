namespace Atividade3.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, decimal preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }
        
    }
}