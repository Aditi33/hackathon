using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Web.Api
{
    public interface ICustomerProcessor
    {
        string Process(Models.Customer customer);
    }
}
