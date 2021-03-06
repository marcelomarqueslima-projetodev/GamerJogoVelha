﻿using GamerJogoVelhaDomain.Interfaces.Repositories;
using GamerJogoVelhaInfraData.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GamerJogoVelhaInfraCrossCutting.InversionOfControl
{
    public static class RepositoryDependency
    {
        public static void AddRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IGameResultRepository, GameResultRepository>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();
        }
    }
}
