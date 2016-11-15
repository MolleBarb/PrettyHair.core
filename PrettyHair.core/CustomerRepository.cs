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
        List<object> Customer;
        public List<object> FindCustomer()
        {
            return Customer;
        }

        public CustomerRepository()
        {

        }
    }
}
