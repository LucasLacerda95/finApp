using finapp.Business.Interfaces;
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

            services.AddScoped<IAccountRepository, AccountRepository>();

            services.AddScoped<IAccountService, AccountService>();

            //services.AddScoped<IUser, AspNetUser>();

            //services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}