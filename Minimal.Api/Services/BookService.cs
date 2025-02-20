using MinimalApis.Models;

namespace MinimalApis.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book> _books =
        [
            new Book
            {
                Id = 1,
                Title = "Dependency Injection in .NET",
                Author = "Mark Seemann"
            },

            new Book
            {
                Id = 2,
                Title = "C# in Depth",
                Author = "Jon Skeet"
            },

            new Book
            {
                Id = 3,
                Title = "Programming Entity Framework",
                Author = "Julia Lerman"
            },

            new Book
            {
                Id = 4,
                Title = "Programming WCF Services",
                Author = "Juval Lowy and Michael Montgomery"
            }
        ];

        public IReadOnlyCollection<Book> GetBooks()
        {
            return _books;
        }

        public Book? GetBook(int id)
        {
            var book = _books.FirstOrDefault(x => x.Id == id);

            return book;
        }
    }
}
