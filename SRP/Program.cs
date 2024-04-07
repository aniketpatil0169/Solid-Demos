using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           product product = new product()
            {
                ProductId = 1,
                Name = "Shirt",
                Price = 599
            };

            ProductDb db = new ProductDb(new FileLogger()); 
            db.Insert(product);

            Console.WriteLine();
        }
    }
}
