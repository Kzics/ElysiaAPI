using ElysiaAPI.Controllers;
using ElysiaAPI.Objects;
using Microsoft.EntityFrameworkCore;

namespace ElysiaAPI;

public class ElysiaDbContext : DbContext
{
    
    public DbSet<VehicleInfo> VehicleInfos { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<PlayerFine> PlayerFines { get; set; }
    public DbSet<Bizs> Bizs { get; set; }
    public DbSet<Warn> Warns { get; set; }

    public ElysiaDbContext(DbContextOptions<ElysiaDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VehicleInfo>().HasKey(v => v.VehicleId);
        modelBuilder.Entity<Vehicle>().HasKey(v => v.Id);
        modelBuilder.Entity<PlayerFine>().HasKey(fine => fine.FineId);
        modelBuilder.Entity<Invoice>().HasKey(invoice => invoice.InvoiceId);
        modelBuilder.Entity<Bizs>().HasKey(bizs => bizs.Id);
    }
}