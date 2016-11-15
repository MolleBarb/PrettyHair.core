using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.core
{ 
    class Order
    {
        public int OrderDate { get; set; }
        public int DeliveryDate { get; set; }
        public int WareNumber { get; set; }
        public int Quantity { get; set; }

        public Order( int date, int delivery, int number, int quantity)
        {
            OrderDate = date;
            DeliveryDate = delivery;
            WareNumber = number;
            Quantity = quantity;

        }

        public Order()
        {

        }







    }
}
