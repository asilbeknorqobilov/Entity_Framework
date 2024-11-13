using EFApp8Linq.Models;
using Microsoft.EntityFrameworkCore;

namespace EFApp8Linq.Data;

public class DataDbContext:DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=localhost;Database=efapp_dblinq;Username=efapp_user8linq;Password=efapp_user8linq");
    }
}