using Hello_ASPNET_CORE.Models;
using Hello_ASPNET_CORE.Repositories;

namespace Hello_ASPNET_CORE.Services
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _repository;

        public EmployeeService(EmployeeRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return _repository.GetAllEmployees();
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            return _repository.GetEmployeeById(id);
        }

        public void AddEmployee(EmployeeModel employee)
        {
            _repository.AddEmployee(employee);
        }

        public void UpdateEmployee(EmployeeModel employee)
        {
            _repository.UpdateEmployee(employee);
        }

        public void DeleteEmployee(int id)
        {
            _repository.DeleteEmployee(id);
        }
    }

}
