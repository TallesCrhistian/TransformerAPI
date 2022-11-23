using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Configuration;
using TransformerAPI.Application.Interfaces;
using TransformerAPI.Application.Services;
using TransformerAPI.Business;
using TransformerAPI.Business.Interfaces;
using TransformerAPI.Data.Context;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Data.Repository;

namespace TransformerAPI
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDataBase(this IServiceCollection services, IConfiguration iConfiguration)
        {
            services.Configure<MongoDbContext>(opt =>
            {
                opt.ConnectionString = iConfiguration.GetSection("MongoConnection:ConnectionString").Value;
                opt.DatabaseName = iConfiguration.GetSection("MongoConnection:Database").Value;
                opt.IsSSL = Convert.ToBoolean(iConfiguration.GetSection("MongoConnection:IsSSL").Value);
            });

            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<ITransformerServices, TransformerServices>();
            services.AddScoped<ITestServices, TestServices>();
            services.AddScoped<IReportServices, ReportServices>();


            return services;
        }

        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<IUserBusiness, UserBusiness>();
            services.AddScoped<ITransformerBusiness, TransformerBusiness>();
            services.AddScoped<ITestBusiness, TestBusiness>();
            services.AddScoped<IReportBusiness, ReportBusiness>();

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITransformerRepository, TransformerRepository>();
            services.AddScoped<ITestRepository, TestRepository>();
            services.AddScoped<IReportRepository, ReportRepository>();

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
