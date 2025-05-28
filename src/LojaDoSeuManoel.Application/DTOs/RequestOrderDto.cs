using LojaDoSeuManoel.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDoSeuManoel.Application.DTOs
{
    public class RequestOrderDto
    {
        public List<OrderDto> Pedidos { get; set; } = new List<OrderDto>();
    }
}
