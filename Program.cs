using System;

namespace BillInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var myBill = new Bill(15.80, .06);

            //myBill.Subtotal = 15.80;
            //myBill.TaxRate = .06;

            pay(myBill);

            var myTippedBill = new TippableBill(8.5, .06, 2.0);

            //myTippedBill.Subtotal = 8.50;
            //myTippedBill.TaxRate = .06;
            //myTippedBill.Tip = 2.00;

            pay(myTippedBill);
            
        }

        static void pay(Bill bill)
        {
            Console.WriteLine($"${bill.CalcTotal()}");

        }
    }
}
