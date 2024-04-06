using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SilcerCustomer sc = new SilcerCustomer();
            //sc.ShowsTiming();

            //GoldCustomer gc = new GoldCustomer();
            //gc.ShowsTiming();

            //PlatiniumCustomer pc = new PlatiniumCustomer();
            //pc.ShowsTiming();



            List<ICustomer> customers = new List<ICustomer>();
            customers.Add(new SilcerCustomer());
            customers.Add(new GoldCustomer());
            customers.Add(new PlatiniumCustomer());
            // customers.Add(new Enquiry());

            foreach (var item in customers)
            {
                // item.ShowsTiming();
                item.PrintTicket();
            }

            Console.ReadLine();
        }
    }
}
