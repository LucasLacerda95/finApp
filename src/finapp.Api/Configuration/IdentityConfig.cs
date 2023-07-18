using System.Text;
using finapp.Api.Data;
using finapp.Api.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace finapp.Api.Configuration
{


    public static class IdentityConfig{


        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services, IConfiguration configuration){



            var serverVersion = new MySqlServerVersion(new Version(11, 0, 2));


            services.AddDbContext<ApplicationDbContext>(options => 
                options.UseMySql(configuration.GetConnectionString("connectionString"), serverVersion));

            
            //Add Identity Configurations
            
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();//Autenticação por email
    

            //JWT

            var appSettingsSection = configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            var AppSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes("appSettings.Secret");

            services.AddAuthentication(x => {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x => {
                x.RequireHttpsMetadata = false;//Restringe a autenticação apenas de client HTTPS
                x.SaveToken = true;//Guardar o Token após autenticação
                x.TokenValidationParameters = new TokenValidationParameters{
                    
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
                    ValidateAudience = true,
                    ValidAudience = AppSettings.ValidIn,
                    ValidIssuer = AppSettings.Issuer

                };
            });


            return services;
        }
    }
}