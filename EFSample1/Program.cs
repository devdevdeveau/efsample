using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EFSample1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var services = CreateHostBuilder(args).Build().Services;

            using var source = new CancellationTokenSource();
            using var scope = services.CreateScope();
            var provider = scope.ServiceProvider;

            var playground = provider.GetRequiredService<EntityFrameworkPlayground>();

            await playground.RunEfCommands(source.Token);

        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    var startup = new Startup(context.Configuration);
                    startup.ConfigureServices(services);
                })
                .UseConsoleLifetime();
        }
    }
}
