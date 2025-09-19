using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryClean
{
    internal class CreditCardPayment : Payment
    {
        private int CardNumber { get; set; }
        

        public void SetNumber(int cardnumber)
        {
            CardNumber = cardnumber;
        }
        public int GetNumber()
        {
            return CardNumber;
        }

        

        public override void ProcessPaymentMessage()
        {
            Console.WriteLine($"You have successfully paid with CreditCard with CardNumber : {CardNumber} and total price = {Amount + 50}");
        }
    }
}
