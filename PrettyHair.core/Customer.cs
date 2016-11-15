using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.core
{
    public class Customer
    {
        public int CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; } 

        public Customer(int number, string name, string address)
        {
            CustomerNumber = number;
            CustomerName = name;
            CustomerAddress = address;

        }
        public Customer()
        {

        }
        
    }
}
