using Microsoft.EntityFrameworkCore;
using EF;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ApplicationContext : DbContext
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=WS-779;Database=EFdb;Trusted_Connection=True;");
    }
    //Так бы он выглядел как обычно 
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //    // Для вынесения конфигурации во вне необходимо создать класс конфигурации, реализующий интерфейс EntityTypeConfiguration<T>
    //     modelBuilder.Entity<Product>().ToTable("Mobiles").HasKey(p=>p.Ident);
    //     modelBuilder.Entity<Product>().Property(c => c.Name).IsRequired().HasMaxLength(30);
    //     modelBuilder.Entity<Company>().ToTable("Manufacturers").Property(c => c.Name).IsRequired().HasMaxLength(30);
    // }
    //Вся конфигурация здесь определена в методе OnModelCreating().
    //В принципе он не содержит много кода, однако при наличии гораздо большего количества сущностей
    //и более изощренной их конфигурации с помощью Fluent API данный метод мог бы сильно раздуться в размерах.
    //И теперь изменим определение контекста, применив конфигурации:



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //для добавления конкретных конфигураций в контекст используется метод modelBuilder.ApplyConfiguration(),
        //которому передается нужный объект конфигурации. В итоге по своему действию первый и второй варианты контекста будут идентичны.
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new CompanyConfiguration());
    }

}
//Теперь конфигурация моделей вынесена в отдельные классы. 
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Mobiles").HasKey(p => p.Ident);
        builder.Property(p=>p.Name).IsRequired().HasMaxLength(30);
    }
}

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable("Manufactures").Property(c=>c.Name).IsRequired().HasMaxLength(30);
    }
}
//или же В качестве альтернативы мы могли бы использовать еще один вариант.
//Вместо выделения отдельных классов конфигураций определить конфигурацию в виде отдельных методов в том же классе контекста данных:

