using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace TravelParty.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["Dev:MongoDbConnectionString"]!;
            var db = configuration["Dev:MainDbName"]!;

            services.AddSingleton(singleton =>  new MongoClient(connectionString).GetDatabase(db));

            return services;
        }
    }
}