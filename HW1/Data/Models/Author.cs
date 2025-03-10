namespace Library.Data.Models;

public class Author
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FullName { get; set; }
    public ICollection<Book> Books { get; set; } = new List<Book>();
}