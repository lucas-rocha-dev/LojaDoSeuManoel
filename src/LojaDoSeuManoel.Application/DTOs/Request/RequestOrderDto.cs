using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDoSeuManoel.Application.DTOs.Request
{
    public class RequestOrderDto
    {
        public List<OrderRequestDto> Pedidos { get; set; } = new List<OrderRequestDto>();
    }
}
