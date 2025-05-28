using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDoSeuManoel.Application.DTOs
{
    public class BoxDto
    {
        public string Caixa_id { get; set; } = string.Empty;
        public List<string> Produtos { get; set; } = new();
    }
}
