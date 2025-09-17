using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryClean
{
    public class Bill
    {
        public int BillId {  get; set; }
        public Order Order { get; set; }
        public Bill(Order o)
        {
            Order = o;
        }

        public string PrintBill(Payment p)
        {
            return $"Thank you for using our service. We hope to cooperate in the future." +
                $"BillID :{BillId} , PaymentMethod : {p.Method} ,  OrderNumber : {Order.OrderId} , totalCost : {Order.CalculateTotal()}";
        }



    }
}
