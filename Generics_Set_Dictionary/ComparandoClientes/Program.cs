using ComparandoClientes.Entities;

namespace ComparandoClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>();
            Console.WriteLine("Digite dois clientes para comparação.");

            for (int i = 0; i < 2; i++)
            {
                Console.Write("\nNome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();

                clients.Add(new Client(name, email));
            }

            Console.WriteLine("\nComparando clientes...");
            Console.WriteLine(clients[0].Equals(clients[1]) ? "Os clientes são iguais." : "Os clientes são diferentes."); // condicional ternária para comparação
        }
    }
}