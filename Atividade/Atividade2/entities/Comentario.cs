namespace Atividade2.Entities
{
    public class Comentario
    {
        public string Texto { get; set; }

        public Comentario()
        {
        }

        public Comentario(string texto) : this()
        {
            Texto = texto;
        }

        public override string ToString()
        {
            return "Texto: "
            + Texto;
        }

    }
}