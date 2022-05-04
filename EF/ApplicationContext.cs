
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace EF
{
    public class ApplicationContext :DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WS-779;Database=EFdb;Trusted_Connection=True;");
        }
    }
}
