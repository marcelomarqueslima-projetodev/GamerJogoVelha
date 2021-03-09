using GamerJogoVelhaDomain.Interfaces.Services;
using GamerJogoVelhaService.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GamerJogoVelhaInfraCrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<IGameResultService, GameResultService>();
        }
    }
}
