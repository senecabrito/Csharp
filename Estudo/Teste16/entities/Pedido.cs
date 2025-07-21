using Teste16.Entities.Enums;

namespace Teste16.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }
        
    }
}