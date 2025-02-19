using Microsoft.OpenApi.Models;
using MinimalApis.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/books", (IBookService bookService) => TypedResults.Ok(bookService.GetBooks()))
    .WithName("GetBooks")
    .WithOpenApi(x => new OpenApiOperation(x)
    {
        Summary = "Get Library Books",
        Description = "Returns information about all the available books from the library.",
        Tags = new List<OpenApiTag>
        {
            new() { Name = "Library" }
        }
    });

await app.RunAsync();