using Microsoft.EntityFrameworkCore;
using EF;

public class ApplicationContext :DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(){
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WS-779;Database=EFdb;Trusted_Connection=True;");
        //журнал лога optionsBuilder.LogTo(System.Console.WriteLine);
        //или же optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message)); в окно отладки - Debug - Output
        optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));
        //уровни логгирования Trace Debug Information Warning Error Critical  None
    }

}

