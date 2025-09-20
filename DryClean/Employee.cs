using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryClean
{
    public class Employee : Person
    {
        public int EmployeeID { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public void ProcessOrder(Order order)
        {
            Console.WriteLine($"{Name} processed order #{order.OrderId}");
        }


        public override string getContactInfo()
        {
            return $"Name : {Name} , Email : {Email}";
        }
    }
}
