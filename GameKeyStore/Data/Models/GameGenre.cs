namespace GameKeyStore.Data.Models;

public class GameGenre
{
    public string GenreRef { get; set; }
    
    public Guid GameRef { get; set; }
        
    public Genre Genre { get; set; }
    
    public Game Game { get; set; }
}