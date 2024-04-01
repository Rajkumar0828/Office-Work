using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeList;
using Employeelist.Model;
using System.Net;
using System.Net.Http;

namespace WebapiList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static readonly EmployeeRepository repository = new IEmployeeRepository();

        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return repository.GetAll();
        }
        [HttpGet("id")]
        public Employee GetEmployees(int id)
        {
            Employee employee = repository.Get(id);
            if (employee == null)
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return null;
                
            }
            return employee;
        }

        [HttpGet("Designation")]
        public IEnumerable<Employee> GetByEmployee(string Designation)
        {
            return repository.GetAll().Where(
                p => string.Equals(p.Designation, Designation, StringComparison.OrdinalIgnoreCase));
        }
        [HttpPost]
        public ActionResult PostProduct(Employee item)
        {
           repository.Add(item);
            
            //string uri = Url.Link("DefaultApi", new { id = item.Id });
           // response.Headers.Location = new Uri(uri);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Employee employee)
        {
            if (id != employee.EmpId)
                return BadRequest();
            else
                repository.Update(employee);
            return Ok();
        }


    }
}
