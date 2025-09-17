using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryClean
{
    public class Order
    {
        public int OrderId {  get; set; }

        public string Status {  get; set; }

        private List<Item> Items { get; set; }

        private List<Service> services { get; set; }

        private Payment payment { get; set; }

        public Order()
        {
            Items = new List<Item>();
            services = new List<Service>();
            Console.WriteLine($"Order is Created {DateTime.Now}...");
        }


        public double CalculateTotal()
        {
            double total = 0;

            foreach (var item in Items)
            {
                total += item.GetPrice();
            }
            foreach (var service in services)
            {
                total += service.GetPrice();
            }
            return total;
        }
        

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void AddService(Service service)
        {
            services.Add(service);
        }

        public void AddPayment(Payment pay)
        {
            payment = pay;
        }


        public void FinishOrder()
        {
            payment = null;
            Console.WriteLine("Thanks for using our services..");
        }
    }
}
