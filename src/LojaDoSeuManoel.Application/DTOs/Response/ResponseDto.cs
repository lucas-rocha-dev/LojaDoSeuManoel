
namespace LojaDoSeuManoel.Application.DTOs.Response
{
    public class ResponseDto
    {
        public List<OrderResponseDto> pedidos { get; set; } = new List<OrderResponseDto>();
    }
}
