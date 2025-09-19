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
            c1.MakeOrder(o1);
            
            Item i1 = new Item( 1 , "TShirt" , 350);
            Item i2 = new Item(2, "Suit", 400);

           c1.order.AddItem(i1);
            c1.order.AddItem(i2);

            Service s1 = new Service(1, "Washing", 50);
            Service s2 = new Service(2, "Washing", 40);

            c1.order.AddService(s1);
            c1.order.AddService(s2);

            double total = o1.CalculateTotal();
            Console.WriteLine($"Total Salary = {total}");


            CreditCardPayment p1 = new CreditCardPayment()
            {
                Amount = total
            };
            p1.SetNumber(5741);
            
            c1.order.AddPayment(p1);
           

            // Make Bill
            Bill b1 = new Bill(o1)
            {
                BillId = 45
            };
            Console.WriteLine(b1.PrintBill(p1));

            c1.order.FinishOrder(); // Close App

        }
    }
}
