using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryClean
{
    public abstract class Payment
    {
        public double Amount {  get; set; }

        public abstract void ProcessPaymentMessage();
        
    }
}
