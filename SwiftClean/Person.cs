using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryClean
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email {  get; set; }

        public abstract string getContactInfo();
    }
}
