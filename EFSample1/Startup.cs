using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EFSample1
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<EntityFrameworkPlayground>();
            services.AddDbContext<MyDbContext>(builder =>
            {
                var connectionString = _configuration.GetConnectionString("MyDbContext");
                builder.UseSqlServer(connectionString);
            });
        }
    }
}