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
        public List<Order> Orders { get; set; } = new List<Order>();
        public override string getContactInfo()
        {
            return $"My phone : {Phone}";
        }

        public string MakeOrder(Order or)
        {
            Orders.Add(or);
            return "The order is created...";
        }



    }
}
