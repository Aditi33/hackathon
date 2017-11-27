using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.Web.Api.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ContactNumber { get; set; }

        public string EmailAddress { get; set; }
    }
}