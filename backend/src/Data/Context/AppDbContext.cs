using System.Transactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MStarSupply.Models;

namespace MStarSupply.Data;

public class AppDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public AppDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }

    /* OBS: Modelo de Dados Customizado: O DbSet mapeia automaticamente, mas aqui conseguimos customizar os
     * campos e relacionamentos das entidades do banco, como por exemplo, conseguimos definir todos os campos
     * string/VARCHAR com um tamanho especifico (100, 120, 200) para todas as entidades do banco de uma só vez.
     */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /* ApplyConfigurationsFromAssembly: Carrega automaticamente os contextos que foram organizados 
         * individualmente em Mappings
         */
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"),
            param => param.EnableRetryOnFailure(
                maxRetryCount: 2,
                maxRetryDelay:
                    TimeSpan.FromSeconds(5),
                    errorCodesToAdd: null
            )
        );
    }
}