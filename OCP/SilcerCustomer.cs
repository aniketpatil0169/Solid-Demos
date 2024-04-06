using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class SilcerCustomer : Customer, ICustomer
    {
        public  void PrintTicket()
        {
            Console.WriteLine("Silver Customer Ticket Printed");
        }
    }
}
