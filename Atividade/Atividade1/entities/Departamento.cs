namespace Atividade1.Entities
{
    // Classe que representa um departamento
    public class Departamento
    {
        public string Nome { get; private set; }

        public Departamento()
        {
        }

        public Departamento(string nome) : this()
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Departamento: {Nome}";
        }

    }
}