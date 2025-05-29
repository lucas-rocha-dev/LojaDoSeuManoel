using LojaDoSeuManoel.Domain.Interfaces;
using LojaDoSeuManoel.Infrastructure.Data;
using LojaDoSeuManoel.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace LojaDoSeuManoel.Infrastructure
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("LojaDoSeuManoelConnection")));


            services.AddScoped<IBoxRepository, BoxRepository>();

        }
    }
}
