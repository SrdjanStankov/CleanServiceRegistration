using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanServiceRegistration.Installers
{
    public class ControllersInstaller : IInstaller
    {
        public void InstallServices(IConfiguration configuration, IServiceCollection services) => services.AddControllers();
    }
}
