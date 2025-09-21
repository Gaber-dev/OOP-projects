using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryClean
{
    public class Item
    {
        public int itemId {  get; set; }
        public string Name { get; set; }

        private double basePrice {  get; set; }

        public Item(int itid , string name , double basep)
        {
            itemId = itid;
            Name = name;
            basePrice = basep;
        }
        public double GetPrice()
        {
            return basePrice;
        }
    }
}
