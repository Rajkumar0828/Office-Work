using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerList
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public int ? Age { get; set; }
        public string? City { get; set; }

    }
}
