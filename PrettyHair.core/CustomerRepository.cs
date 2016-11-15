using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PrettyHair.core
{   
    
    
    public class CustomerRepository
    {
        List<Customer> customerList;
        public List<Customer> FindCustomers()
        {
            
            return customerList;
        }

        public CustomerRepository()
        {
            customerList = new List<Customer>();
            customerList.Add(new Customer(1, "Pelle", "Glanshatten"));
            customerList.Add(new Customer(2, "Torben", "Somewhere"));
        }

    }
}
