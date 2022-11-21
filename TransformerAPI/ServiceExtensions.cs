using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace TransformerAPI
{
    public static class ServiceExtensions
    {

        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            return services;
        }

        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {

            return services;
        }
    }
}
