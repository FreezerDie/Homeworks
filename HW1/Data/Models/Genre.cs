namespace Library.Data.Models;

public class Genre
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public ICollection<Book> books { get; set; }    
}