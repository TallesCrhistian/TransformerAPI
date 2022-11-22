using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using TransformerAPI.Application.Interfaces;
using TransformerAPI.Application.Services;
using TransformerAPI.Business;
using TransformerAPI.Business.Interfaces;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Data.Repository;

namespace TransformerAPI
{
    public static class ServiceExtensions
    {

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<ITransformerServices, TransformerServices>();

            return services;
        }

        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<IUserBusiness, UserBusiness>();
            services.AddScoped<ITransformerBusiness, TransformerBusiness>();

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITransformerRepository, TransformerRepository>();

            return services;
        }
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TransformerAPI", Version = "v1" });
                
                c.OperationFilter<SecurityRequirementsOperationFilter>();
            });
            return services;
        }
        }
}
