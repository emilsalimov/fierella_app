using Fiorella.Domain.Entities;
using Fiorella.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Fiorella.Persistence.Contexts;

public class AppDbContex: DbContext
{
    public AppDbContex(DbContextOptions<AppDbContex> options):base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }

}
