using Carter;
using Microsoft.OpenApi.Models;
using MinimalApis.Services;

namespace Minimal.Api.Modules
{
    public sealed class BooksModule : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
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
        }
    }
}
