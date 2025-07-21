using System.Collections.Generic;
using System.Text;
using Atividade3.Entities.Enums;

namespace Atividade3.Entities
{
    public class Pedido
    {
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();

        public Pedido()
        {
        }

        public Pedido(DateTime momento, StatusPedido status, Cliente cliente) : this()
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void AdicionarItem(ItemPedido item)
        {
            Itens.Add(item);
        }

        public void RemoverItem(ItemPedido item)
        {
            Itens.Remove(item);
        }

        public decimal Total()
        {
            return Itens.Sum(item => item.SubTotal()); // Calcula o total do pedido somando os subtotais de cada item
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Momento do pedido: {Momento}");
            sb.AppendLine($"Status do pedido: {Status}");
            sb.AppendLine($"Cliente: {Cliente}");
            sb.AppendLine("Itens do pedido:");

            foreach (ItemPedido item in Itens)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine($"Total do pedido: {Itens.Sum(item => item.SubTotal()):C}"); // Calcula o total do pedido
            return sb.ToString();
        }

    }
}