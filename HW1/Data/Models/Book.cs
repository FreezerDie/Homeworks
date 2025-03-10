namespace Library.Data.Models;

public class Book
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public Guid AuthorId { get; set; }
    public Author Author { get; set; }
    public ICollection<Genre> Genres { get; set; }
}