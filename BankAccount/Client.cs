using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Client
    {
        public string Name{ get; set; }
        public string Address{ get; set; }

        public string Phone {  get; set; }

        public BankAccount BankAccount { get; set; }

        public Client(string name  ,string address , string phone ,BankAccount ba)
        {
            Name = name;
            Address = address;
            Phone = phone;
            BankAccount = ba;
        }


        public override string ToString()
        {
            return $"Name = {Name} , Address = {Address} , Phone = {Phone} , {BankAccount.ToString()}";
        }
    }
}
