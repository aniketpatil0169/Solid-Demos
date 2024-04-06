using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class PlatiniumCustomer : Customer, ICustomer
    {
        // platinium customer specific method
        public  void PrintTicket()
        {
            Console.WriteLine("Platinium Customer Ticket Printed");
        }
    }
}
