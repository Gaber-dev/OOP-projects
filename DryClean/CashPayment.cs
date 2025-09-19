using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryClean
{
    public class CashPayment : Payment
    {
        public string Method {  get; set; }
        public override void ProcessPaymentMessage()
        {
            Console.WriteLine($"You have successfully paid with {Method} and total price = {Amount + 50}");
        }
    }
}
