
namespace LojaDoSeuManoel.Domain.Entities
{
    public class Box
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } 
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Comprimento { get; set; }


        public Box() { }
        public Box(string name, int altura, int largura, int comprimento)
        {
            Id = Guid.NewGuid();
            Nome = name;
            Altura = altura;
            Largura = largura;
            Comprimento = comprimento;
        }
       

    }
}
