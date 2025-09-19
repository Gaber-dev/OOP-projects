using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryClean
{
    public class Customer : Person
    {
        public string Address {  get; set; }
        public Order order { get; set; }
        public override string getContactInfo()
        {
            return $"My phone : {Phone}";
        }

        public void MakeOrder(Order or)
        {
            order = or ;
            
        }
    }
}
