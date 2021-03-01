using GamerJogoVelhaDomain.Interfaces.Services;
using GamerJogoVelhaServices.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GamerJogoVelhaInfraCrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<GameService, GameService>();
        }
    }
}
