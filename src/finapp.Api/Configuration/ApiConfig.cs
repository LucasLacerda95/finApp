using finapp.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace finapp.Api.Configuration
{

    public static class ApiConfig
    {

        public static IServiceCollection AddWebApiConfig(this IServiceCollection services)
        {

            services.AddControllers();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();


            return services;
        }


        public static IApplicationBuilder UseWebApiConfig(this WebApplication app)
        {

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            return app;
        }

        public static IServiceCollection AddEntityConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var serverVersion = new MySqlServerVersion(new Version(11, 0, 2));

            services.AddDbContext<DataContext>
            (options => options
                .UseMySql(configuration.GetConnectionString("connectionString"), serverVersion));


            return services;
        }

    }
}