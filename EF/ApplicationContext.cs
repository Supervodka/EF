using Microsoft.EntityFrameworkCore;
using EF;
public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }
   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //С помощью Fluent API можно создать составной ключ из нескольких свойств 
        modelBuilder.Entity<User>().HasKey(u => new { u.PassportSeria, u.PassportNumber });
        //и можно настроить имя ограничения, которое задается для первичного ключа.Для этого применяется метод HasName():
        //modelBuilder.Entity<User>().HasKey(u => u.Id).HasName("UsersPrimaryKey");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=WS-779;Database=EFdb;Trusted_Connection=True;");
    }
}

