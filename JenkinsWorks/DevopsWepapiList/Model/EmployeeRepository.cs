
using EmployeeList;
namespace Employeelist.Model
{
    public interface EmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        Employee Add(Employee employee);
        void Remove(int id);
        bool Update(Employee employee);
    }
}
