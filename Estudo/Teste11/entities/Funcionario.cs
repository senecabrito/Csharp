namespace Teste11.Entities
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public int Id { get; private set; }
        private decimal _salario;

        public Funcionario(string nome, int id, decimal salario)
        {
            Nome = nome;
            Id = id;
            _salario = salario;
        }

        public decimal Salario
        {
            get { return _salario; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salário não pode ser negativo.");
                }
                _salario = value;
            }
        }

        public void AumentarSalario(decimal porcentagem)
        {
            _salario += _salario * porcentagem / 100;
        }

        public override string ToString()
        {
            return $"ID: {Id}\nNome: {Nome}\nSalário: {_salario:C}";
        }
    }
}