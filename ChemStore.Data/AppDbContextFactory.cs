using ChemStore.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ChemStore.Data;

public class AppDbContextFactory
    : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var options =
            new DbContextOptionsBuilder<AppDbContext>();

        options.UseSqlite(
            "Data Source=ChemStore.db");

        return new AppDbContext(options.Options);
    }
}
