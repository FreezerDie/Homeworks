namespace GameKeyStore.Data.Models;

public class Warehouse
{
    public Guid id { get; set; } = Guid.NewGuid();
    public Guid ProductId { get; set; }
    
    public Game Game { get; set; }
    
    public int Count { get; set; } = 0;
}