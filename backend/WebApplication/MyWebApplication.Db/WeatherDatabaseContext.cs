using Microsoft.EntityFrameworkCore;

namespace MyWebApplication.Db;

public class WeatherDatabaseContext : DbContext
{
    
    public WeatherDatabaseContext(DbContextOptions options) : base(options)
    {
    }

    public WeatherDatabaseContext()
    {
    }

    public virtual DbSet<WeatherForecast> WeatherForecasts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer("Server=tcp:sql-server-auingerc.database.windows.net,1433;Initial Catalog=sql-database-auingerc;Persist Security Info=False;User ID=auingerc;Password=htlgkr1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}
