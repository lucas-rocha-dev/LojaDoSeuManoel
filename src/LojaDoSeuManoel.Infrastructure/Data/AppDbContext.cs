using LojaDoSeuManoel.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace LojaDoSeuManoel.Infrastructure.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
         public DbSet<Box> Boxes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Box>().HasData(
            new Box { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), Nome = "Caixa 1", Altura = 30, Largura = 40, Comprimento = 80 },
            new Box { Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), Nome = "Caixa 2", Altura = 80, Largura = 50, Comprimento = 40 },
            new Box { Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"), Nome = "Caixa 3", Altura = 50, Largura = 80, Comprimento = 60 }
);
        }

    }
}
