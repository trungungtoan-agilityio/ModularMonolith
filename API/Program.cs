using Microsoft.OpenApi.Models;
using Module.Catalog.Extensions;
using Shared.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSharedInfrastructure(config);
builder.Services.AddCatalogModule(config);

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API",
        Description = "Modular Architecture in ASP.NET Core",
        Version = "v1"
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();