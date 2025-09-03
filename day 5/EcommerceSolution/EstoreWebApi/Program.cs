using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;

// builder.Services.AddOpenApi();
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
var app = builder.Build();
app.MapGet("/Hhello", () => "Hello World!");
// Enable middleware to serve generated Swagger as a JSON endpoint and Swagger UI

app.MapGet("/kcp/product", () =>
{
    return new[]{
    new { Id = 1, Name = "Product 1", Price = 10.0 },
    new { Id = 2, Name = "Product 2", Price = 10.0 }
    };
});
app.UseSwagger();
app.UseSwaggerUI();
app.Run();
