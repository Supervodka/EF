using Microsoft.EntityFrameworkCore;
using EF;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public ApplicationContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=WS-779;Database=EFdb;Trusted_Connection=True;");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Для инициализации БД при конфигурации определенной модели вызывается метод HasData(), в который передаются добавляемые данные:
        //как вариант modelBuilder.Entity<User>().HasData( new User { Id=1, Name="Tom", Age=36}); или же:
        modelBuilder.Entity<User>().HasData(
            new User []
            {
               new User() {Id = 1,Name = "Tom", Age = 33},
               new User() {Id = 2,Name = "Alice",Age = 25},
               new User() {Id = 3,Name = "Nick",Age = 40},

            });


    }
}
