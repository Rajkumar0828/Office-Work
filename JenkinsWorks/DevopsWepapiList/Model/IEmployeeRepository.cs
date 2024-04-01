using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Employeelist.Model;
using EmployeeList;
namespace Employeelist.Model
{
    public class IEmployeeRepository : EmployeeRepository
    {
        private List<Employee> employees = new List<Employee>();
        private int _nextId = 1;
        public IEmployeeRepository()
        {
            Add(new Employee{ EmpId=11987, Name="Rajkumar", Designation="Developer", Salary=25000 });
            
        }
        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }

        public Employee Get(int id)
        {
            return employees.Find(p => p.EmpId == id);
        }

        public Employee Add(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("item");
            }
            employee.EmpId = _nextId++;
            employees.Add(employee);
            return employee;
        }

        public void Remove(int id)
        {
            employees.RemoveAll(p => p.EmpId == id);
        }
        public bool Update(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = employees.FindIndex(p => p.EmpId == employee.EmpId);
            if (index == -1)
            {
                return false;
            }
            employees.RemoveAt(index);
            employees.Add(employee);
            return true;
        }
    }
}
