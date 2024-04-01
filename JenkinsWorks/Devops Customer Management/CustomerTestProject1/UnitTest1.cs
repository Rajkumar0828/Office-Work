using CustomerList.Controllers;
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
        public void Post_with_id_returns_OkResult()
        {
            CustomerController addCustomerController = new CustomerController();

            Customer customer = new Customer()
            {
                CustomerId = 11987,
                FirstName = "Rajkumar",
                LastName = "Ramanathan",
                Age =22,
                City = "Thoothukudi"
            };
            var result = addCustomerController.PostCustomer(customer);

            Assert.IsInstanceOf<OkResult>(result);
        }


    }
}