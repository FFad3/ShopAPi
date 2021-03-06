using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace ShopAPI.Installers
{
    public class SwaggerInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ShopAPI", Version = "v1" });
            });
        }
    }
}
