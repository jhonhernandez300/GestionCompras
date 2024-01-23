using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//used for configuring the application and services.
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//registers services needed for handling HTTP requests, including the MVC framework for handling controllers, actions, and views.
builder.Services.AddControllers();

//adds services that support API exploration. It's related to generating OpenAPI/Swagger documentation for the API. The API Explorer services are used to discover and explore API endpoints.
builder.Services.AddEndpointsApiExplorer();
//adds services required for Swagger/OpenAPI documentation generation. Swagger is a tool that helps document and test APIs. This service is part of the Swashbuckle library
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LionDev.ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


//used to add authentication services to the application's service collection.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    //adds the JWT Bearer authentication handler with the specified options.
    .AddJwtBearer(options => {
        IConfiguration configuration = builder.Configuration;

        if (configuration != null)
        {
            options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = configuration["Jwt:Issuer"],
                ValidAudience = configuration["Jwt:Audience"],
                // converts the JWT key (which is assumed to be a string) from the configuration into a SymmetricSecurityKey for token validation.
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]))
            };
        }
        else
        {
            // Handle the case where configuration is null
            throw new InvalidOperationException("Configuration is null.");
        }
    });

//This line builds the IHost
var app = builder.Build();

app.UseCors(options => options.WithOrigins("http://localhost:4200")
                .AllowAnyMethod()
                .AllowAnyHeader()
            );

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//This middleware redirects HTTP requests to HTTPS. It ensures that all communication is done over a secure (encrypted) connection.
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.UseAuthorization();

//This middleware maps HTTP requests to controller actions. 
app.MapControllers();
//This line starts the application and begins listening for incoming HTTP requests. It's the entry point for the application's execution.
app.Run();
