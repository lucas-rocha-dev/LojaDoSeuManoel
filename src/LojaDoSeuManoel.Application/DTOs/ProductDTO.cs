using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDoSeuManoel.Application.DTOs
{
    public class ProductDTO
    {
        public string Produto_id { get; set; }
        public DimensoesDto Dimensoes { get; set; } = new();

    }
}
