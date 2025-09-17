namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount(1 , 50000);
            SavingBankAccount acc2 = new SavingBankAccount(2 , 90000);

            Client c1 = new Client("Gaber", "Alexandria - Mamoura", "01002387286", acc1);
            Client c2 = new Client("Mahmoud", "Alexandria - Asafra", "01001732545", acc2);

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            c1.BankAccount.Deposit(5000);
            Console.WriteLine(c1);

            

        }
    }
}
