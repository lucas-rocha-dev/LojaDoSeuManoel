using LojaDoSeuManoel.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDoSeuManoel.Application.DTO
{
    public class OrderDto
    {
        public int Pedido_id { get; set; }
        public List<ProductDTO> produtos { get; set; } = new();
    }
}
