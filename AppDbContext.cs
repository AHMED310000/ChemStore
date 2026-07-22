using ChemStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace ChemStore.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();
}