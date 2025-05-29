using System.Text.Json.Serialization;

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
