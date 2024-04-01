using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CustomerList;
using Customerlist.Model;
using System.Net;
using System.Net.Http;

namespace CustomerList.Controllers
{
    [Route("travelagencyrest/api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        static readonly CustomerRepository repository = new ICustomerRepository();

        [HttpGet]
        public IEnumerable<Customer> GetAllCustomer()
        {
            return repository.GetAll();
        }
        [HttpGet("id")]
        public Customer GetCustomer(int id)
        {
            Customer customer = repository.Get(id);
            if (customer == null)
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return null;

            }
            return customer;
        }

        [HttpGet("City")]
        public IEnumerable<Customer> GetCustomerByCity(string City)
        {
            return repository.GetAll().Where(
                p => string.Equals(p.City, City, StringComparison.OrdinalIgnoreCase));
        }
        [HttpPost]
        public ActionResult PostCustomer(Customer customer)
        {
            repository.Add(customer);

            //string uri = Url.Link("DefaultApi", new { id = item.Id });
            // response.Headers.Location = new Uri(uri);
            return Ok();
        }



    }
}

