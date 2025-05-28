using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDoSeuManoel.Domain.Entities
{
    public class Box
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public decimal Altura { get; set; }
        public decimal Largura { get; set; }
        public decimal Comprimento { get; set; }

       public Box(string name, decimal altura, decimal largura, decimal comprimento)
        {
            Name = name;
            Altura = altura;
            Largura = largura;
            Comprimento = comprimento;
        }
        
    }
}
