using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LojaDoSeuManoel.Application.DTOs.Response
{
    public class BoxResponseDto
    {
        public string Caixa_id { get; set; } = string.Empty;
        public List<string> Produtos { get; set; } = new();
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Observacao { get; set; }
    }
}
//{ "produto_id": "PS5", "dimensoes": { "altura": 40, "largura": 10, "comprimento": 25} },
//{ "produto_id": "Volante", "dimensoes": { "altura": 40, "largura": 30, "comprimento": 30} }