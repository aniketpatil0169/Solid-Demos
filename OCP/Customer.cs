using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public abstract class Customer
    {
        public void ShowsTiming()
        {
            Console.WriteLine("*** ALL TODAYS SHOW ***");
        }

       // public abstract void PrintTicket();
    }

    public interface ICustomer
    {
        void PrintTicket();
    }

    public interface ICustomerNew : ICustomer
    {
        void FreeFoodOrder();
    }
}
