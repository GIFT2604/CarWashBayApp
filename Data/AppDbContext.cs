using Microsoft.EntityFrameworkCore;
using CarWashBayApp.Models;

namespace CarWashBayApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { }

    public DbSet<Washer> Washers { get; set; }
    public DbSet<Car> Cars { get; set; }
}
