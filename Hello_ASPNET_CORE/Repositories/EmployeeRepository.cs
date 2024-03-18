using Hello_ASPNET_CORE.Models;
using Microsoft.EntityFrameworkCore;

namespace Hello_ASPNET_CORE.Repositories
{
    public class EmployeeRepository
    {
        private readonly EmployeeDbConext _context;

        public EmployeeRepository(EmployeeDbConext context)
        {
            _context = context;
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }

        public void AddEmployee(EmployeeModel employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void UpdateEmployee(EmployeeModel employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }
    }

}
