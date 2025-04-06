using GameKeyStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GameKeyStore.Data.Contexts;

public class GameStoreContext : DbContext
{
    public DbSet<Game> Games { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<GameGenre> GameGenres { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    
    public GameStoreContext(DbContextOptions<GameStoreContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(GameStoreContext).Assembly);
    }
}