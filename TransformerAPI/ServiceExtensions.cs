﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using MongoDB.Driver;
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
            services.Configure<TransformerDatabaseSettings>(
                iConfiguration.GetSection(nameof(TransformerDatabaseSettings)));

            services.AddSingleton<ITransformerDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<TransformerDatabaseSettings>>().Value);

            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<ITransformerServices, TransformerServices>();
            services.AddScoped<ITestServices, TestServices>();

            return services;
        }

        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<IUserBusiness, UserBusiness>();
            services.AddScoped<ITransformerBusiness, TransformerBusiness>();
            services.AddScoped<ITestBusiness, TestBusiness>();

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ITransformerRepository, TransformerRepository>();
            services.AddTransient<ITestRepository, TestRepository>();

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
