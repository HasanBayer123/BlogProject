using Microsoft.EntityFrameworkCore;

namespace CoreBlogAPI.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LCK25ST;database=CoreBlogApiDb; integrated security=true; TrustServerCertificate=True");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
