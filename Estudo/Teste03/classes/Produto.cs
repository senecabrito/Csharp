namespace Teste3.Classes
{
    public class Produto // Propriedades no encapsulamento
    {
        private string _nome;
        private decimal _preco;
        private int _quantidade;

        public Produto(string nome, decimal preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, decimal preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public decimal Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public void AdicionarQuantidade(int quantidade)
        {
            if (quantidade > 0)
            {
                _quantidade += quantidade;
            }
        }

        public void RemoverQuantidade(int quantidade)
        {
            if (quantidade > 0 && _quantidade >= quantidade)
            {
                _quantidade -= quantidade;
            }
        }

        public override string ToString()
        {
            return $"Produto: {_nome}\nPreço: {_preco:C}\nQuantidade: {_quantidade}";
        }

    }
}