using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
	public class AContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SELVITOPCU\\SQLEXPRESS;database=CoreBlogApiDb; integrated security=true;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
