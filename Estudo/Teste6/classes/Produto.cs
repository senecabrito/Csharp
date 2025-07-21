namespace Teste6.Classes
{
    public class Produto
    {
        private string _nome;
        public decimal Preco { get; private set; }

        public Produto(string nome, decimal preco)
        {
            _nome = nome;
            Preco = preco;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do produto não pode ser vazio ou nulo.");
                }
                _nome = value;
            }
        }


    }
}