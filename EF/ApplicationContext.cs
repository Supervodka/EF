using Microsoft.EntityFrameworkCore;
using EF;
public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasKey(u => u.Ident);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=WS-779\;Database=EFdb;Trusted_Connection=True;");
    }


}

//Для конфигурации ключа с Fluent API применяется метод HasKey():
// public class ApplicationContext : DbContext
// {
//     public DbSet<User> Users { get; set; }
//
//
//     protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//         modelBuilder.Entity<User>().HasKey(u => u.Ident);
//     }
//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//         optionsBuilder.UseSqlServer(@"Server=WS-779\;Database=EFdb;Trusted_Connection=True;");
//     }
//
//     public class User
//     {
//         public int Ident { get; set; }
//         public string? Name { get; set; }
//     }
//
//
// }