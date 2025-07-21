using Atividade3.Entities;
using Atividade3.Entities.Enums;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = CadastrarCliente();
            Pedido p1 = InformarPedido(c1);

            Console.Write("Quantos itens tem nesse pedido: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Produto produto = CadastrarProduto();
                ItemPedido itemPedido = CadastrarItemPedido(produto);
                p1.AdicionarItem(itemPedido);
                Console.WriteLine();
            }

            Console.WriteLine();

            ExibirPedido(p1);
        }

        static Cliente CadastrarCliente()
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o e-mail do cliente: ");
            string email = Console.ReadLine();

            Console.Write("Digite a data de nascimento do cliente (DD/MM/YYYY): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            return new Cliente(nome, email, dataNascimento);
        }

        static Pedido InformarPedido(Cliente cliente)
        {
            DateTime momento = DateTime.Now;

            Console.Write("\nInforme o status do pedido (Pendente, Processando, Enviado, Entregue): ");
            StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());

            return new Pedido(momento, status, cliente);
        }

        static Produto CadastrarProduto()
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            return new Produto(nome, preco);
        }

        static ItemPedido CadastrarItemPedido(Produto produto)
        {
            Console.Write("Digite a quantidade do item: ");
            int quantidade = int.Parse(Console.ReadLine());

            return new ItemPedido(quantidade, produto.Preco, produto);
        }

        static void ExibirPedido(Pedido pedido)
        {
            Console.WriteLine("\nDetalhes do Pedido: ");
            Console.WriteLine(pedido.ToString());
        }
        
    }
} 