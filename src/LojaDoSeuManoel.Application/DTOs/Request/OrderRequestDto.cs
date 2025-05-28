using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDoSeuManoel.Application.DTOs.Request
{
    public class OrderRequestDto
    {
        public int Pedido_id { get; set; }
        public List<ProductRequestDto> produtos { get; set; } = new();
    }
}
