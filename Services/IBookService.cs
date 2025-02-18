using MinimalApis.Models;

namespace MinimalApis.Services;

public interface IBookService
{
    List<Book> GetBooks();
        
    Book GetBook(int id);
}