namespace Teste8.Classes
{
    public class Hospede
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int Quarto { get; private set; }

        public Hospede(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }
        
    }
}