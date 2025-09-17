using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryClean
{
    public class Payment
    {
        public double Amount {  get; set; }

        public string Method {  get; set; }


        public void ProcessPayment()
        {
            Console.WriteLine("This service is successfully done..");
        }
    }
}
