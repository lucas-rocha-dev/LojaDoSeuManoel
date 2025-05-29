

namespace LojaDoSeuManoel.Application.DTOs.Request
{
    public class RequestOrderDto
    {
        public List<OrderRequestDto> Pedidos { get; set; } = new List<OrderRequestDto>();
    }
}
