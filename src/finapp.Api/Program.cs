using finapp.Api.Configuration;
using finapp.Data.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("connectionString")));
    

builder.Services.AddIdentityConfiguration(builder.Configuration); //Configuration/IdentityConfig

builder.Services.ResolveDependencies(); //Configuration/DependencyInjectionConfig

builder.Services.AddWebApiConfig(); //Configuration/ApiConfig


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();//Adiciona Middlewere de autenticação, encapsula o acesso à API

app.UseWebApiConfig();//Configuration/ApiConfig

app.Run();