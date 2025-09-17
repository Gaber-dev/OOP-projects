namespace DryClean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer()
            {
                Name = "Gaber mohamed",
                Phone = "01002387286",
                Email = "GM@gmail.com",
                Address = "Alexandria"
            };

            


            Order o1 = new Order()
            {
                OrderId = 1,
                Status = "Created"
            };

            Item i1 = new Item( 1 , "TShirt" , 350);
            Item i2 = new Item(2, "Suit", 400);

            o1.AddItem(i1);
            o1.AddItem(i2);

            Service s1 = new Service(1, "Washing", 50);
            Service s2 = new Service(2, "Washing", 40);

            o1.AddService(s1);
            o1.AddService(s2);

            double total = o1.CalculateTotal();
            Console.WriteLine($"Total Salary = {total}");


            Payment p1 = new Payment()
            {
                Amount = total , 
                Method = "Cash"
            };
            o1.AddPayment(p1);
            p1.ProcessPayment();

            // Make Bill
            Bill b1 = new Bill(o1)
            {
                BillId = 45,

            };
            Console.WriteLine(b1.PrintBill(p1));

            o1.FinishOrder();

        }
    }
}
