using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        protected int AccountID { get; set; }
        protected double Balance {  get; set; }

        public BankAccount()
        {
            Balance = 0;
        }

        public BankAccount(int id , double balance)
        {
            AccountID = id;
            Balance = balance;
        }

        public int GetID()
        {
            return AccountID;
        }

        public void SetID(int id)
        {
            AccountID = id;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public virtual void Withdraw(double amount)
        {
            if(amount > Balance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Success Withdraw");
            }
        }

        public virtual void Deposit(double amount)
        {
            Balance+= amount;
            Console.WriteLine("Success Deposit");
        }

        public override string ToString()
        {
            return $"AccountID = {AccountID} and Balance = {Balance}";
        }
    }
}
