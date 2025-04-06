namespace GameKeyStore.Data.Models;

public class Game
{
    public Guid Id { get; set; } = Guid.NewGuid();
    
    public string GameName { get; set; }

    public string ImagePath { get; set; }
    
    public string Publisher { get; set; }
    
    public decimal Price { get; set; }

    public ICollection<Genre> Genres { get; set; }
}