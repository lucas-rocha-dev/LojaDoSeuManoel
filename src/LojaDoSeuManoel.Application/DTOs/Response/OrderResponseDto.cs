
namespace LojaDoSeuManoel.Application.DTOs.Response
{
    public class OrderResponseDto
    {
        public int Pedido_id { get; set; }
        public List<BoxResponseDto> Caixas { get; set; } = new();
    }
}
