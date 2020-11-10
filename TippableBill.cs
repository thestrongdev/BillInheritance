using System;
using System.Collections.Generic;
using System.Text;

namespace BillInheritance
{
    class TippableBill : Bill
    {
        public double Tip { get; set; }

        public TippableBill() //default constructor
        {

        }

        public TippableBill(double subtotal, double taxrate, double tip)
        {
            Subtotal = subtotal;
            TaxRate = taxrate;
            Tip = tip;
        }

        public override double CalcTotal()
        {
            double totalBill = (Subtotal * (1 + TaxRate)) + Tip;

            return totalBill;
        }

    }
}
