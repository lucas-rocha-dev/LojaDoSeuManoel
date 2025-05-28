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
        public string Nome { get; set; } 
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Comprimento { get; set; }

       public Box(string name, int altura, int largura, int comprimento)
        {
            Nome = name;
            Altura = altura;
            Largura = largura;
            Comprimento = comprimento;
        }
        
    }
}
