using elev8.Models;
using Microsoft.EntityFrameworkCore;

namespace elev8.EntityFramework
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Database=Elev8Todo;Trusted_Connection=true;");

        public DbSet<Todo> Todos { get; set; }
    }
}
