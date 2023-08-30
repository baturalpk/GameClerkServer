namespace GameClerkServer.Data;

using Microsoft.EntityFrameworkCore;
using GameClerkServer.Features.GameplayActivity;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("MainDataStore"));
    }

    public DbSet<GameplayActivity> GameplayActivities { get; set; }
}
