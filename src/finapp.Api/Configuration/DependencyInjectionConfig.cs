using finapp.Api.Data;
using finapp.Data.Context;

namespace finapp.Api.Configuration{

    public static class DependencyInjectionConfig{

        public static IServiceCollection ResolveDependencies(this IServiceCollection services){

           services.AddScoped<DataContext>();   

            return services;
        }
    }
}