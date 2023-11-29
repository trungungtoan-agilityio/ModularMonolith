using Microsoft.EntityFrameworkCore;
using Module.Catalog.Core.Abstractions;
using Module.Catalog.Core.Entities;
using Shared.Infrastructure.Persistence;

namespace Module.Catalog.Infrastructure.Persistence;

public class CatalogDbContext(DbContextOptions<CatalogDbContext> options, DbSet<Brand> brands)
    : ModuleDbContext(options), ICatalogDbContext
{
    protected override string Schema => "Catalog";

    public DbSet<Brand> Brands { get; set; } = brands;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
