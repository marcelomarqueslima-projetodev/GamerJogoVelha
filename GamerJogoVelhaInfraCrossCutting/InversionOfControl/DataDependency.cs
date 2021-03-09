using GamerJogoVelhaInfraData.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GamerJogoVelhaInfraCrossCutting.InversionOfControl
{
    public static class DataDependency
    {
        public static void AddDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GameContext>(options =>
            {
                var server = configuration["database:mysql:server"];
                var port = configuration["database:mysql:port"];
                var database = configuration["database:mysql:database"];
                var username = configuration["database:mysql:username"];
                var password = configuration["database:mysql:password"];

                options.UseMySQL($"Server={server};Port={port};Database={database};Uid={username};Pwd={password}");
            });
        }
    }
}
