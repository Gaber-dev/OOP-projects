using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class SavingBankAccount:BankAccount
    {
        private double MinimumBalance {  get; set; }

        public SavingBankAccount(int accountid , double initialbalance , double minimumbalance = 1000):base(accountid , initialbalance)
        {
            if(minimumbalance > initialbalance)
            {
                throw new ArgumentException("Initial balance must be >= minimum balance.");
            }
            MinimumBalance = minimumbalance;
        }

        public override void Deposit(double amount)
        {
            if (amount > 100)
            {
                base.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Deposit must be with 100 point at least");
            }
        }

        public override void Withdraw(double amount)
        {
            if(MinimumBalance < (Balance - amount))
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Can not withdraw");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"minimumbalance = {MinimumBalance}";
            ;
        }


    }
}
