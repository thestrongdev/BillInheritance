using System;
using System.Collections.Generic;
using System.Text;

namespace BillInheritance
{
    class TippableBill : Bill
    {
   
        private double _tip;
        public double Tip { get => _tip; set => _tip = value; }

        public TippableBill() //default constructor
        {

        }

        public TippableBill(double subtotal, double taxrate, double tip) //overload constructor
        {
            Subtotal = subtotal;
            TaxRate = taxrate;
            _tip = tip;
        }

        

        public override double CalcTotal()
        {
            double totalBill = (Subtotal * (1 + TaxRate)) + Tip;

            return totalBill;
        }

    }
}
