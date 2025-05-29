

namespace LojaDoSeuManoel.Application.DTOs.Request
{
    public class OrderRequestDto
    {
        public int Pedido_id { get; set; }
        public List<ProductRequestDto> produtos { get; set; } = new();
    }
}
