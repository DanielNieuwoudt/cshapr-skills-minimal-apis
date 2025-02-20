using MinimalApis.Models;

namespace MinimalApis.Services;

public interface IBookService
{
    IReadOnlyCollection<Book> GetBooks();
        
    Book? GetBook(int id);
}