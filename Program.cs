using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ChemStore.UI;

public static class Program
{
    public static IHost AppHost { get; private set; } = null!;

    public static void Configure()
    {
        AppHost = Host.CreateDefaultBuilder()
            .ConfigureServices(ServiceRegistration.Register)
            .Build();
    }
}
