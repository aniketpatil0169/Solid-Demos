using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class ProductDb
    {
        ILogger _log;

        public ProductDb(ILogger log)
        {
            _log = log;
        }

        public void Insert(product product) 
        {
            try
            {
                // ado.net code
            }
            catch (Exception ex)
            {
                string message = $"Error occured : {ex.Message} at {DateTime.Now}\n";
                // log error details to text file 
                // File.AppendAllText(@"Data\errors.txt", message);
                //FileLogger log = new FileLogger();
                //log.Log(message);
                _log.Log(message);

            }
        } 
    }
}
