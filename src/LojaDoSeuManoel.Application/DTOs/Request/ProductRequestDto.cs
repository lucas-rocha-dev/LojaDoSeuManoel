using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDoSeuManoel.Application.DTOs.Request
{
    public class ProductRequestDto
    {
        public string Produto_id { get; set; }
        public DimensoesRequestDto Dimensoes { get; set; } = new();

    }
}
