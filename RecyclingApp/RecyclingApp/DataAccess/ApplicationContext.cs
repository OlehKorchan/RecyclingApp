using Microsoft.EntityFrameworkCore;
using RecyclingApp.DataAccess.Models;

namespace RecyclingApp.DataAccess;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecyclingPlace>();
    }
}