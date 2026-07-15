using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

using ChemStore.Data.Context;
using ChemStore.Data.Repositories;
using ChemStore.Services;
using ChemStore.Services.Interfaces;

namespace ChemStore.UI;

public partial class App : Application
{
    public static IHost Host { get; private set; } = null!;

    public App()
    {
        Host = Microsoft.Extensions.Hosting.Host
            .CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlite("Data Source=ChemStore.db"));

                services.AddScoped<IProductRepository, ProductRepository>();

                services.AddScoped<IProductService, ProductService>();

                services.AddTransient<ProductsViewModel>();
                services.AddTransient<ProductEditorViewModel>();

                services.AddTransient<MainWindow>();
            })
            .Build();
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        await Host.StartAsync();

        var window = Host.Services.GetRequiredService<MainWindow>();

        window.Show();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        await Host.StopAsync();

        Host.Dispose();

        base.OnExit(e);
    }
}
