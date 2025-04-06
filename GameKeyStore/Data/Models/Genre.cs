namespace GameKeyStore.Data.Models;

public class Genre
{
    public string GenreName { get; set; }

    public ICollection<Game> Games { get; set; }
}