using Atividade2.Entities;

namespace Atividade2.Entities
{
    public class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public Post()
        {
        }

        public Post(DateTime momento, string titulo, string conteudo, int likes) : this()
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AddComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }

        public void RemoverComentario(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }

        public override string ToString()
        {
            return "Post: \n"
            + "Momento: "
            + Momento.ToString("dd/MM/yyyy HH:mm:ss\n")
            + "Titulo: "
            + Titulo + "\n"
            + "Conteudo: "
            + Conteudo + "\n"
            + "Likes: "
            + Likes + "\n";
        }

    }
}