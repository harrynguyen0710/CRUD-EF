using Microsoft.EntityFrameworkCore;
using CRUD_EF.Models.DBEntities;
namespace CRUD_EF.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() { }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }

    }
}
