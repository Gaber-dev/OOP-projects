using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryClean
{
    public class Service
    {
        public int ServiceId {  get; set; }
        public string Name {  get; set; }

        private double Price {  get; set; }

        public Service(int srid, string name, double pr)
        {
            ServiceId = srid;
            Name = name;
            Price = pr;
        }

        public double GetPrice()
        {
            return Price;
        }

    }
}
