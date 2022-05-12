using Microsoft.EntityFrameworkCore;
using EF;
public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=WS-779;Database=EFdb;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //В Fluent API для подобной задачи применяется метод HasColumnType:
        modelBuilder.Entity<User>().Property(u => u.Name).HasColumnType("varchar(200)");
    }
}

