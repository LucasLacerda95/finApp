using finapp.Api.Extensions;
using finapp.Business.Interfaces;
using finapp.Business.Models;
using finapp.Business.Services;
using finapp.Data.Context;
using finapp.Data.Repository;


namespace finapp.Api.Configuration
{

    public static class DependencyInjectionConfig
    {

        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {

            services.AddScoped<DataContext>();


            services.AddScoped<IAccount, Account>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IAccountService, AccountService>();


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();

            //services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}