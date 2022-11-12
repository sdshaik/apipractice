using Microsoft.EntityFrameworkCore;
namespace DAl.Models
{
    public class EmpContext:DbContext
    {
        public EmpContext(DbContextOptions options):base(options)
        {
                            
        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmpID=1,
                EmpName="abc",
                Empsal=123
            });

        }

    }
}
