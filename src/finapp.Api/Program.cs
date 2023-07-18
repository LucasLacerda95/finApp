using finapp.Api.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddEntityConfiguration(builder.Configuration);//Entity Context configuration
    

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