using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class VIPCustomer : Customer, ICustomerNew
    {
        public void FreeFoodOrder()
        {
            Console.WriteLine("Pickup Food");
        }
        public void PrintTicket()
        { 
            Console.WriteLine("VIP Customer Ticket Printed");
        }
    }
}
