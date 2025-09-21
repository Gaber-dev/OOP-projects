using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryClean
{
    public class Paypal : Payment
    {
        private int AccountNumber {  get; set; }

        public Paypal(int acc)
        {
            AccountNumber = acc;
        }
        public override void ProcessPaymentMessage()
        {
            Console.WriteLine($"You have successfully paid Paypal account : {AccountNumber} and total Amount is {Amount + 50} ");
        }
    }
}
