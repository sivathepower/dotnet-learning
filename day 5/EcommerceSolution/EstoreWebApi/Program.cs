using Microsoft.Extensions.DependencyInjection;
// using Swashbuckle.AspNetCore.SwaggerGen;

// builder.Services.AddOpenApi();
var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddSwaggerGen();
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
// Enable middleware to serve generated Swagger as a JSON endpoint and Swagger UI

app.MapGet("/api/product", () =>
{
    return new[]{
    new { Id = 1, Name = "Product 1", Price = 10.0 },
    new { Id = 2, Name = "Product 2", Price = 20.0 }
    };
});
app.MapPost("/api/products", (dynamic product) =>
{
    // In a real application, you would save the product to a database
    return Results.Created($"/api/products/{product.Id}", product);
});
app.MapPut("/api/products/{id}", (int id, dynamic product) =>
{
    // In a real application, you would save the product to a database
    return Results.Ok(product);
});
app.MapDelete("/api/products/{id}", (int id) =>
{
    // In a real application, you would delete the product from a database
    return Results.NoContent();
});
app.Run();
