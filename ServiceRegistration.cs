using ChemStore.Data.Context;
using ChemStore.Data.Repositories;
using ChemStore.Services;
using ChemStore.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ChemStore.UI;

public static class ServiceRegistration
{
    public static void Register(
        HostBuilderContext context,
        IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlite("Data Source=ChemStore.db");
        });

        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IProductService, ProductService>();

        services.AddTransient<MainWindow>();
        services.AddTransient<ProductsView>();
        services.AddTransient<ProductsViewModel>();
    }
}
