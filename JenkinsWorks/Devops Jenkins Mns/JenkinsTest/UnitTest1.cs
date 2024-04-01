using WebapiList.Controllers;
using Customerlist.Model;
using CustomerList;
using Microsoft.AspNetCore.Mvc;


namespace JenkinsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Post_with_0_id_returns_OkResult()
        {
            CustomerController addemployeeController = new CustomerController();

            Customer customer = new Customer()
            {
                CustomerId = 11987,
                FirstName = "Rajkumar",
                LastName = "Ramanathan",
                City = "Thoothukudi"
            };
            var result = addemployeeController.PostCustomer(customer);

            Assert.IsInstanceOf<OkResult>(result);
        }

    
    }
}