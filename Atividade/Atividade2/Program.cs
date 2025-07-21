using Atividade2.Entities;
using System.Collections.Generic;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p1 = CriarPost();
            AdicionarComentarios(p1);
            ExibirPost(p1);
        }

        static Post CriarPost()
        {
            List<Comentario> comentarios = new List<Comentario>();

            Console.Write("Digite o momento do post (DD/MM/YYYY hh:mm:ss): ");
            DateTime momento = DateTime.Parse(Console.ReadLine());

            Console.Write("Digite o título do post: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite o conteúdo do post: ");
            string conteudo = Console.ReadLine();

            Console.Write("Digite a quantidade de likes: ");
            int likes = int.Parse(Console.ReadLine());

            Post p1 = new Post(momento, titulo, conteudo, likes);

            return p1;
        }

        static void AdicionarComentarios(Post p1)
        {
            Console.Write("\nDigite a quantidade de comentários: ");
            int quantidadeComentarios = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeComentarios; i++)
            {
                Console.Write("Digite o texto do comentário: ");
                string textoComentario = Console.ReadLine();
                Comentario comentario = new Comentario(textoComentario);
                p1.AddComentario(comentario);
            }

        }
        
        static void ExibirPost(Post p1)
        {
            Console.WriteLine();
            Console.WriteLine(p1.ToString());
            Console.WriteLine("Comentários:");

            foreach (Comentario comentario in p1.Comentarios)
            {
                Console.WriteLine(comentario.ToString());
            }
        }

    }
}