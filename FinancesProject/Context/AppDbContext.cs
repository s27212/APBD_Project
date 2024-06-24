using FinancesProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinancesProject.Context;

public class AppDbContext(IConfiguration config, DbContextOptions options) : DbContext(options)
{
    private readonly string? _connectionString = config.GetConnectionString("DefaultConnection") ??
                                                 throw new ArgumentNullException(nameof(config), "Connection string is not set");

    public DbSet<Client> Clients { get; set; }
    public DbSet<IndividualClient> IndividualClients { get; set; }
    public DbSet<Company> Companies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}