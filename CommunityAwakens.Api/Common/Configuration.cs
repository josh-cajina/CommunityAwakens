using CommunityAwakens.Application.Common.Configuration;
using CommunityAwakens.Application.Context;
using CommunityAwakens.Application.Services;
using CommunityAwakens.Persistence.Context;
using CommunityAwakens.Persistence.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CommunityAwakens.Api.Common
{
    public static class Configuration
    {
        public static void AddCustomMvc(this IServiceCollection service)
        {
            service
                .AddMvcCore()
                .AddJsonOptions(config =>
                {
                    config.JsonSerializerOptions.IgnoreNullValues = true;
                    //  Convert to camelCase
                    config.JsonSerializerOptions.PropertyNamingPolicy = null;
                    config.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                });
        }

        public static void AddCustomServices(this IServiceCollection serviceCollection)
        {
            AddEventService(serviceCollection);
        }

        private static void AddEventService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IEventService, EventService>();
        }

        public static void AddLiteDb(this IServiceCollection serviceCollection, string dbPath)
        {
            serviceCollection.AddTransient<ILiteDbContext, LiteDbContext>();
            serviceCollection.Configure<LiteDbConfig>(options => options.DbPath = dbPath);
        }
    }
}
