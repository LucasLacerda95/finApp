namespace finapp.Api.Configuration{

    public static class ApiConfig{

        public static IServiceCollection AddWebApiConfig(this IServiceCollection services){

            services.AddControllers();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();


            return services;
        }


        public static IApplicationBuilder UseWebApiConfig(this WebApplication app){

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            return app;
        }
        
    }
}