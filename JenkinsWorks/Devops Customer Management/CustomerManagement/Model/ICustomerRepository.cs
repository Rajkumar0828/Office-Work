using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Customerlist.Model;
using CustomerList;
namespace Customerlist.Model
{
    public class ICustomerRepository : CustomerRepository
    {
        private List<Customer> customers = new List<Customer>();
        private int _nextId = 1;
        public ICustomerRepository()
        {
            Add(new Customer { CustomerId = 11987, FirstName = "Rajkumar", LastName = "Ramanathan",Age=22, City = "Thoothukudi" });

        }
        public IEnumerable<Customer> GetAll()
        {
            return customers;
        }

        public Customer Get(int id)
        {
            return customers.Find(p => p.CustomerId == id);
        }

        public Customer Add(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException("item");
            }
            customer.CustomerId = _nextId++;
            customers.Add(customer);
            return customer;
        }

        public void Remove(int id)
        {
            customers.RemoveAll(p => p.CustomerId == id);
        }

    }
}

