using Hello_ASPNET_CORE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Hello_ASPNET_CORE
{
    public class EmployeeDbConext : DbContext
    {
        public DbSet<EmployeeModel> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
     => options.UseInMemoryDatabase("EmployeeDB");

    }
}
