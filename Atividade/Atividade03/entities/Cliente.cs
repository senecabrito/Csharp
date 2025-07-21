namespace Atividade3.Entities
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string email, DateTime dataNascimento) : this()
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nE-Mail: {Email}\nData de Nascimento: {DataNascimento:dd/MM/yyyy}";
        }
        
    }
}