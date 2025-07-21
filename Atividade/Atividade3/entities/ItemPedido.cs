namespace Atividade3.Entities
{
    public class ItemPedido
    {
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public Produto Produto { get; set; }

        public ItemPedido()
        {
        }

        public ItemPedido(int quantidade, decimal preco, Produto produto) : this()
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public decimal SubTotal()
        {
            decimal subtotal = Quantidade * Preco;
            return subtotal;
        }

        public override string ToString()
        {
            return $"{Produto.Nome}, {Quantidade} unidades, Preço unitário: {Preco:C}, Subtotal: {SubTotal():C}";
        }
        
    }
}