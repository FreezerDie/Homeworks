namespace GameKeyStore.Data.Models;

public class GameGenre
{
    public Guid id { get; set; } = Guid.NewGuid();
    public string GenreRef { get; set; }
    
    public Guid GameRef { get; set; }
        
    public Genre Genre { get; set; }
    
    public Game Game { get; set; }
}