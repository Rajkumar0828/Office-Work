using APICrudclient.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICrudclient.Controllers
{
   public class CustomerController : Controller


   {

        private readonly APIGateway _apiGateway;
    public CustomerController(APIGateway ApiGateway)
    {
        _apiGateway = ApiGateway;
    }



    public IActionResult Index()
    {
        List<Customer> customers;

        customers = _apiGateway.ListCustomers();
        return View(customers);
    }


    [HttpGet]
    public IActionResult Create()
    {
        Customer customer =new  Customer();
        return View(customer);
    }

    [HttpPost]
    public IActionResult Create(Customer customer)
    {
    
        _apiGateway.CreateCustomer(customer);
        return RedirectToAction("index");
    }


     public IActionResult Details(int id)
    {
       Customer customer =new  Customer();
       customer = _apiGateway.GetCustomer(id);
        return View(customer);
    }


    [HttpGet]
    public IActionResult Edit(int Id)
    {
         Customer customer;
       customer = _apiGateway.GetCustomer(Id);
        return View(customer);
    }    
    [HttpPost]
    public IActionResult Edit(Customer customer)
    {
        _apiGateway.UpdateCustomer(customer);
          return RedirectToAction("index");
    }

    [HttpGet]
    public IActionResult Delete(int Id)
    {
         Customer customer;
          customer = _apiGateway.GetCustomer(Id);
        return View(customer);
    }

    [HttpPost]
    public IActionResult Delete(Customer customer)
    {
        _apiGateway.DeleteCustomer(customer.Id);
          return RedirectToAction("index");
    }





   }
}