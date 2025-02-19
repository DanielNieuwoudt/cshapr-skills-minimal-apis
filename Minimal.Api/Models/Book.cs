namespace MinimalApis.Models
{
    public sealed record Book
    {
        public int Id { get; init; }

        public string Title { get; init; } = string.Empty;

        public string Author { get; init; } = string.Empty;
    }
}
